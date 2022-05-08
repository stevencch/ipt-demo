namespace Demo.Ipt.Web.Core.Models.Proposal;
public class ProposalModel
{
    public ProposalModel()
    {
        Facilities=new List<FacilityModel>();
    }
    public int ProposalId { get; set; }
    public string ProposalName { get; set; }
    public string CustomerGrpName { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public List<FacilityModel> Facilities { get; set; }
}
