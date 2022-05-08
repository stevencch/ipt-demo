namespace Demo.Ipt.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProposalController : ControllerBase
{
    private readonly IProposalService _proposalService;
    private readonly ILogger<ProposalController> _logger;

    public ProposalController(IProposalService proposalService, ILogger<ProposalController>  logger)
    {
        _proposalService = proposalService;
        _logger = logger;
    }
    [HttpGet("GetData")]
    public async Task<IEnumerable<ProposalModel>> GetData(CancellationToken ct = default)
    {
        return await _proposalService.GetProposalsAsync(ct);
    }
}
