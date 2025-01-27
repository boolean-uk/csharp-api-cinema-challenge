using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerView>();

            CreateMap<Movie, MovieView>();

            CreateMap<Screen, ScreenView>();
            CreateMap<Screen, ScreenInternal>();

            CreateMap<Screening, ScreeningView>();
            CreateMap<Screening, ScreeningScreen>();

        }
    }
}
