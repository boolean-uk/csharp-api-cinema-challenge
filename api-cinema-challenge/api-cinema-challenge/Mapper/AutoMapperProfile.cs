using api_cinema_challenge.DTO;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using AutoMapper;
using System.Numerics;

namespace api_cinema_challenge.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieDTO>();
            CreateMap<Customer, CustomerDTO>();
            CreateMap<Screening, ScreeningDTO>();
            CreateMap<Exception, ErrorResponse>();
        }
    }
}
