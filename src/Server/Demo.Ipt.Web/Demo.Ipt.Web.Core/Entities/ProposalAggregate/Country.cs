namespace Demo.Ipt.Web.Core.Entities.ProposalAggregate;
public class Country: BaseEntity //ValueObject
{
    public string Name { get; set; }
    public string Currency { get; set; }
}
