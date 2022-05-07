using Demo.Ipt.Web.Infrastructure.Data;

namespace Demo.Ipt.Web.Infrastructure.Queries;
public class ProposalQuery : IProposalQuery
{
    private readonly IptDbContext _dbContext;

    public ProposalQuery(IptDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<ProposalModel>> GetProposalsAsync(CancellationToken ct = default)
    {
        var sql = @"
SELECT p.Id as ProposalId,
	   p.ProposalName,
	   p.CustomerGrpName,
	   p.Date,
	   p.Description,
	   ps.Status,
	   t.Id as FacilityId,
	   t.FacilityName,
	   t.Name,
	   t.Currency,
	   t.StartDate,
	   t.MaturityDate,
	   t.Limit
FROM Proposals AS p with(nolock)
JOIN ProposalStatuses AS ps with(nolock) ON p.StatusId = ps.Id
LEFT JOIN (
    SELECT  f.Id,
			f.BookingCountryId,
			f.FacilityName,
			f.Limit,
			f.MaturityDate,
			f.StartDate,
			f.ProposalId,
			c.Currency,
			c.Name
    FROM Facilities AS f  with(nolock)
    LEFT JOIN Countries AS c with(nolock) ON f.BookingCountryId = c.Id
) AS t ON p.Id = t.ProposalId
ORDER BY p.ProposalName,
         t.FacilityName
";
        using var connection =  new SqlConnection(_dbContext.Database.GetConnectionString());
        var proposals = await connection.QueryAsync<ProposalModel, FacilityModel, ProposalModel>(sql, (proposal, facility) =>
        {
            if (facility != null && proposal != null)
            {
                proposal.Facilities.Add(facility);
            }
            return proposal;
        },
        splitOn: "FacilityId");
        return proposals;
    }
}
