using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Screening, ScreeningDTO>();
            CreateMap<ScreeningPOST, Screening>();

            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerPOST, Customer>();
            CreateMap<CustomerPUT, Customer>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) =>
                    srcMember != null && (!srcMember.GetType().IsValueType || !Equals(srcMember, 0))
                ));

            CreateMap<Movie, MovieDTO>();
            CreateMap<Movie, MovieWScreeningsDTO>();
            CreateMap<MoviePOST, Movie>();
            CreateMap<MoviePUT, Movie>()
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) =>
                    srcMember != null && (!srcMember.GetType().IsValueType || !Equals(srcMember, 0))
                ));

            CreateMap<Ticket, TicketDTO>();
            CreateMap<TicketPOST, Ticket>();

            CreateMap(typeof(object), typeof(ResponseSingleDTO<>))
           .ForMember("Data", opt => opt.MapFrom((src, dest) => src));

            CreateMap(typeof(IEnumerable<>), typeof(ResponseDTO<>))
            .ForMember("Data", opt => opt.MapFrom((src, dest) => src));

        }

    }
}
