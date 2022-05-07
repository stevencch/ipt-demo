namespace Demo.Ipt.Web.Core.Specifications;
public class ProposalWithFacilitiesSpecification : Specification<Proposal>
{
    public ProposalWithFacilitiesSpecification()
    {
        Query.Include(x => x.Status).Include(x => x.Facilities).ThenInclude(x => x.BookingCountry);
    }
}
