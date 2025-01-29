using System;

namespace api_cinema_challenge.DTOs;



public class CreateScreenMovieDTO
{
    public int AvailableSeats {get;set;}
    public int ScreenId {get;set;}
    public int MovieId {get;set;}
    public DateTime StartsAt {get;set;}
}

public class GetScreenMovieDTO
{
    public int AvailableSeats {get;set;}
    public int ScreenId {get;set;}
    public int MovieId {get;set;}
    public DateTime StartsAt {get;set;} 
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
}

public class GetTicketScreenMovieDTO //Screenmovie version when queried from the ticket
{
    public int Id {get;set;}
    public int AvailableSeats {get;set;}
    public GetScreenMovieGetScreenDTO Screen {get;set;}
    public GetScreenMovieGetMovieDTO Movie {get;set;}
    public DateTime StartsAt {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
}


public class GetMovieScreenMovieDTO //ScreenMovie version when queried from a Movie
{
    public int Id {get;set;}
    public int AvailableSeats {get;set;}
    public GetScreenMovieGetScreenDTO Screen {get;set;}
    public DateTime StartsAt {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
}

public class GetScreenScreenMovieDTO //ScreenMovie version when queried from a Screen
{
    public int Id {get;set;}
    public int AvailableSeats {get;set;}
    public GetScreenMovieGetMovieDTO Movie {get;set;}
    public DateTime StartsAt {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
}