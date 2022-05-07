namespace Demo.Ipt.Web.Core.Services;

public interface IProposalService
{
    Task<IEnumerable<ProposalModel>> GetProposalsAsync(CancellationToken ct = default);
    Task<IEnumerable<ProposalModel>> GetProposalsFromRawAsync(CancellationToken ct = default);
}
