using api_cinema_challenge.DTO.Requests;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using AutoMapper;
namespace api_cinema_challenge.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerResponseDto>();
            CreateMap<Screening, ScreeningResponseDto>();
            CreateMap<Ticket, TicketResponseDto>();
            CreateMap<Movie, MovieResponseDto>();

            CreateMap<CustomerRequestDto, Customer>();
            CreateMap<CustomerUpdateDto, Customer>();

            CreateMap<ScreeningRequestDto, Screening>();

            CreateMap<TicketRequestDto, Ticket>();


            CreateMap<MovieRequestDto, Movie>();
            CreateMap<MovieUpdateDto, Movie>();
        }
        
    }
}
