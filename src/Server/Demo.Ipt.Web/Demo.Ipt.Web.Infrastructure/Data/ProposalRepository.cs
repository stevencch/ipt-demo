namespace Demo.Ipt.Web.Infrastructure.Data;
public class ProposalRepository : EfRepository<Proposal>, IProposalRepository
{
    public ProposalRepository(IptDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Proposal>> GetProposalsAsync(CancellationToken ct = default)
    {
        return await ListAsync(new ProposalWithFacilitiesSpecification(),ct);
    }
}
