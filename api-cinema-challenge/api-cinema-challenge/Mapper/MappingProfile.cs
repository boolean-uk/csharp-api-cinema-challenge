using api_cinema_challenge.Models.DTOs;
using AutoMapper;
using System.Numerics;
using api_cinema_challenge.Models;


public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Customer, GetCustomerDTO>();

        CreateMap<PostCustomerDTO, Customer>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
            .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
            .ForMember(dest => dest.Tickets, opt => opt.Ignore());

        CreateMap<PatchCustomerDTO, Customer>()
           .ForMember(dest => dest.Name, opt => opt.Condition(src => !string.IsNullOrEmpty(src.Name)))
           .ForMember(dest => dest.Email, opt => opt.Condition(src => !string.IsNullOrEmpty(src.Email)))
           .ForMember(dest => dest.Phone, opt => opt.Condition(src => !string.IsNullOrEmpty(src.Phone)));
    }
}
