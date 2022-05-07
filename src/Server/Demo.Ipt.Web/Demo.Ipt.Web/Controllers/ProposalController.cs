namespace Demo.Ipt.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProposalController : ControllerBase
{
    private readonly IProposalService _proposalService;

    public ProposalController(IProposalService proposalService)
    {
        _proposalService = proposalService;
    }
    [HttpGet("GetData")]
    public async Task<IEnumerable<ProposalModel>> GetData(CancellationToken ct = default)
    {
        return await _proposalService.GetProposalsAsync(ct);
    }
}
