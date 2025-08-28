using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Customer, CustomerGet>();
            CreateMap<Movie, MovieGet>();
            CreateMap<Screening, ScreeningGet>();
            CreateMap<Ticket, TicketGet>();


            CreateMap<MovieGet, ApiResponse<MovieGet>>();
            CreateMap<CustomerGet, ApiResponse<CustomerGet>>();
            CreateMap<ScreeningGet, ApiResponse<ScreeningGet>>();
            CreateMap<TicketGet, ApiResponse<TicketGet>>();

            CreateMap<Movie, MovieGetScreenings>();

            CreateMap<CustomerPut, Customer>();
            CreateMap<CustomerPost, Customer>();
            CreateMap<MoviePost, Movie>();
            CreateMap<ScreeningPost, Screening>();
            CreateMap<TicketPost, Ticket>();

            //CreateMap<ApiResponse>
        }
        

    }
}
