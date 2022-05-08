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
        var sql = @"exec SP_GetProposalsWithFacilities";
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
        var aggregatedProposals = new List<ProposalModel>();
        foreach(var item in proposals)
        {
            var proposal=aggregatedProposals.FirstOrDefault(x=>x.ProposalId==item.ProposalId);
            if (proposal != null)
            {
                proposal.Facilities.AddRange(item.Facilities);
            }
            else
            {
                aggregatedProposals.Add(item);
            }
        }
        return aggregatedProposals;
    }
}
