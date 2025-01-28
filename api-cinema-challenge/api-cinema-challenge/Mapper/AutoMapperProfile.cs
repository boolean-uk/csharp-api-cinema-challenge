using AutoMapper;

namespace api_cinema_challenge.Mapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Models.Customer, DTO.CustomerResponse>();

        CreateMap<DTO.CustomerPost, Models.Customer>();
    }
}