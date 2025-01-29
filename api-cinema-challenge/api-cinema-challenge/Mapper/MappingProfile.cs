using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<Ticket, TicketDTO>();
            CreateMap<Screening, ScreeningDTO>();
            CreateMap<Movie, MovieDTO>();
        }
    }
}
