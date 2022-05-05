namespace Demo.Ipt.Web.Core.Entities.ProposalAggregate;

public class Proposal : BaseEntity, IAggregateRoot //ValueObject
{
    public Proposal()
    {
        Facilities = new List<Facility>();
    }
    public string ProposalName { get; set; }
    public string CustomerGrpName { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public ProposalStatus Status { get; set; }
    public ICollection<Facility> Facilities { get; set; }

    public void AddFacility(string facilityName,Country bookingCountry,DateTime startDate,DateTime maturityDate,decimal limit)
    {
        Facilities.Add(new Facility
        {
            FacilityName = facilityName,
            BookingCountry = bookingCountry,
            StartDate = startDate,
            MaturityDate = maturityDate,
            Limit = limit
        });
    }
}

