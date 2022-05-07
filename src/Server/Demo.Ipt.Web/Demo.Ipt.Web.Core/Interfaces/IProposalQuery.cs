namespace Demo.Ipt.Web.Core.Interfaces;
public interface IProposalQuery
{
    Task<IEnumerable<ProposalModel>> GetProposalsAsync(CancellationToken ct = default);
}
