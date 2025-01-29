using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<Movie, MovieDTO>();
            CreateMap<Customer, CustomerDTO>();
            CreateMap<Screening, ScreeningDTO>();
        }
    }
}
