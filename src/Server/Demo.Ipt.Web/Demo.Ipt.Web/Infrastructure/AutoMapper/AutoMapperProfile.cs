namespace Demo.Ipt.Web.Infrastructure.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Proposal, ProposalModel>()
            .ForMember(dest => dest.ProposalId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.Status))
            ;

        CreateMap<Facility, FacilityModel>()
            .ForMember(dest => dest.FacilityId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.BookingCountry.Currency))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.BookingCountry.Name))
            ;
    }
}
