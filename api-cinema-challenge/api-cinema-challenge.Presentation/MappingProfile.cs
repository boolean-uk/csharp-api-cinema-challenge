using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Presentation.DTOs.Customers;
using api_cinema_challenge.Presentation.DTOs.Movies;
using api_cinema_challenge.Presentation.DTOs.Screenings;
using AutoMapper;

namespace api_cinema_challenge.Presentation
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, GetCustomerDTO>();

            CreateMap<Movie, GetMovieDTO>();

            CreateMap<AddScreeningDTO, Screening>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ScreenNumber));
            CreateMap<Screening, GetScreeningDTO>()
                .ForMember(dest => dest.ScreenNumber, opt => opt.MapFrom(src => src.Id));
        }
    }
}
