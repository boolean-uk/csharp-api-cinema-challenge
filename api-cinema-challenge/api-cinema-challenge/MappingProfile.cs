using AutoMapper;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();

            CreateMap<Movie, MovieDTO>();
            CreateMap<MovieDTO, Movie>();

            CreateMap<Screening, ScreeningDTO>();
            CreateMap<ScreeningDTO, Screening>();

            CreateMap<Ticket, TicketDTO>();
            CreateMap<TicketDTO, Ticket>();
        }
    }
}
