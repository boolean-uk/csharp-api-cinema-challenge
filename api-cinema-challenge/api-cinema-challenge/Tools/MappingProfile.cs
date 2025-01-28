using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Customer, CustomerDTO>();

            CreateMap<Movie, MovieDTO>();

            CreateMap<Screening, ScreeningDTO>();

            CreateMap<Ticket, TicketDTO>();
        }
    }
}
