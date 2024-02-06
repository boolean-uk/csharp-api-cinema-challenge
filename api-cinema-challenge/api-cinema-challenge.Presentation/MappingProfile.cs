using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Presentation.DTOs.Customers;
using AutoMapper;

namespace api_cinema_challenge.Presentation
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, GetCustomerDTO>();
        }
    }
}
