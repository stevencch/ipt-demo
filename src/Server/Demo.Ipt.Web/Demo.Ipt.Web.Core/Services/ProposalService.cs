namespace Demo.Ipt.Web.Core.Services;
public class ProposalService : IProposalService
{
    private readonly IProposalRepository _proposalRepository;
    private readonly IProposalQuery _proposal;
    private readonly IMapper _mapper;

    public ProposalService(IProposalRepository proposalRepository,
        IProposalQuery proposal,
        IMapper mapper)
    {
        _proposalRepository = proposalRepository;
        _proposal = proposal;
        _mapper = mapper;
    }
    /// <summary>
    /// Get Proposals with Entity Framework
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProposalModel>> GetProposalsAsync(CancellationToken ct = default)
    {
        var proposals = await _proposalRepository.GetProposalsAsync(ct);
        return proposals.Select(x => _mapper.Map<ProposalModel>(x));
    }
    /// <summary>
    /// Get Proposals from stored procedure with Dapper
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProposalModel>> GetProposalsFromRawAsync(CancellationToken ct = default)
    {
        var proposals = await _proposal.GetProposalsAsync(ct);
        return proposals;
    }
}
