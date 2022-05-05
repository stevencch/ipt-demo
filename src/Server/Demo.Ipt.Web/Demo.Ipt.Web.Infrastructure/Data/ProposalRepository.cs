namespace Demo.Ipt.Web.Infrastructure.Data;
public class ProposalRepository : EfRepository<Proposal>, IProposalRepository
{
    public ProposalRepository(IptDbContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Proposal>> GetProposalsAsync()
    {
        throw new NotImplementedException();
    }
}
