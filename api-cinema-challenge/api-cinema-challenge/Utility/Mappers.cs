using System;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Utility;

public class Mappers : Profile
{

    public Mappers()
    {

        //ScreenMovie mappers
        CreateMap<ScreenMovie, GetTicketScreenMovieDTO>();
        CreateMap<ScreenMovie, GetMovieScreenMovieDTO>();
        CreateMap<ScreenMovie, GetScreenScreenMovieDTO>();
        CreateMap<ScreenMovie, GetScreenMovieDTO>();
        CreateMap<CreateScreenMovieDTO, ScreenMovie>();


        // Customer Mappers
        CreateMap<Customer, GetCustomerDTO>();
        CreateMap<CreateCustomerDTO, Customer>();
        

        //Movie Mappers
        CreateMap<Movie, GetMovieDTO>();
        CreateMap<Movie, GetScreenMovieGetMovieDTO>();
        CreateMap<CreateMovieDTO, Movie>();

        //Screen Mappers
        CreateMap<Screen, GetScreenDTO>();
        CreateMap<Screen, GetScreenMovieGetScreenDTO>();
        CreateMap<CreateScreenDTO, Screen>();

        //Ticket mappers
        CreateMap<Ticket, GetTicketDTO>();
        CreateMap<CreateTicketDTO, Ticket>();

        

    }

}
