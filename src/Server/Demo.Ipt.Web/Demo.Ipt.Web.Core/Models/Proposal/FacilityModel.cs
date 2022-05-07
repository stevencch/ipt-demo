namespace Demo.Ipt.Web.Core.Models.Proposal;
public class FacilityModel
{
    public int FacilityId { get; set; }
    public string FacilityName { get; set; }
    public string Country { get; set; }
    public string Currency { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime MaturityDate { get; set; }
    public decimal Limit { get; set; }
    public ProposalModel Proposal { get; set; }
}
