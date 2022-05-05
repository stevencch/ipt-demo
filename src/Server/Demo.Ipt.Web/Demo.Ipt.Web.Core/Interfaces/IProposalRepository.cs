namespace Demo.Ipt.Web.Core.Interfaces;
public interface IProposalRepository:IRepository<Proposal>
{
    Task<IEnumerable<Proposal>> GetProposalsAsync();
}
