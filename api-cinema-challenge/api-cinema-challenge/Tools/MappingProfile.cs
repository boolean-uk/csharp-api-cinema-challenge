using System;
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Calls;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Customer mappings
        CreateMap<Customer, CustomerDTO>();
        CreateMap<CustomerPost, Customer>();
        CreateMap<CustomerPut, Customer>();

        // Movie mappings
        CreateMap<Movie, MovieDTO>();
        CreateMap<MoviePost, Movie>();
        CreateMap<MoviePut, Movie>();

        // Screening mappings
        CreateMap<Screening, ScreeningDTO>();
        CreateMap<ScreeningPost, Screening>();

        // Ticket mappings
        CreateMap<Ticket, TicketDTO>();
        CreateMap<TicketPost, Ticket>();
    }
}