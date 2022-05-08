namespace Demo.Ipt.Web.Core.Services;
public class ProposalService : IProposalService
{
    private readonly IProposalRepository _proposalRepository;
    private readonly IProposalQuery _proposal;
    private readonly IMapper _mapper;
    private readonly ILogger<ProposalService> _logger;

    public ProposalService(IProposalRepository proposalRepository,
        IProposalQuery proposal,
        IMapper mapper,
        ILogger<ProposalService> logger)
    {
        _proposalRepository = proposalRepository;
        _proposal = proposal;
        _mapper = mapper;
        _logger = logger;
    }
    /// <summary>
    /// Get Proposals with Entity Framework
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProposalModel>> GetProposalsAsync(CancellationToken ct = default)
    {
        try
        {
            var proposals = await _proposalRepository.GetProposalsAsync(ct);
            return proposals.Select(x => _mapper.Map<ProposalModel>(x));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"{nameof(GetProposalsAsync)} has error");
            throw;
        }
    }
    /// <summary>
    /// Get Proposals from stored procedure with Dapper
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<ProposalModel>> GetProposalsFromRawAsync(CancellationToken ct = default)
    {
        try
        {
            var proposals = await _proposal.GetProposalsAsync(ct);
            return proposals;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"{nameof(GetProposalsFromRawAsync)} has error");
            throw;
        }
    }
}
