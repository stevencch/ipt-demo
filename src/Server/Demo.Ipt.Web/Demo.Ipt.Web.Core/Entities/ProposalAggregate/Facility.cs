namespace Demo.Ipt.Web.Core.Entities.ProposalAggregate;
public class Facility: BaseEntity
{
    public string FacilityName { get; set; }
    public Country BookingCountry { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime MaturityDate { get; set; }
    public decimal Limit { get; set; }
}
