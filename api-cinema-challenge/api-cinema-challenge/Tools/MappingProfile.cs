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

            CreateMap(typeof(IEnumerable<>), typeof(ResponseDTO<>))
            .ForMember("Data", opt => opt.MapFrom((src, dest) => src));
        }

    }
}
