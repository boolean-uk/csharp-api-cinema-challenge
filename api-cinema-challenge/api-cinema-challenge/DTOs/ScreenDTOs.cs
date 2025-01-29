using System;

namespace api_cinema_challenge.DTOs;


public class GetScreenDTO
{
    public int Id {get;set;}
    public int ScreenNumber {get;set;}
    public int Capacity {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    public List<GetScreenScreenMovieDTO> ScreenMovies {get;set;}
}

public class CreateScreenDTO
{
    public int ScreenNumber {get;set;}
    public int Capacity {get;set;}
}

public class GetScreenMovieGetScreenDTO
{
    public int Id {get;set;}
    public int ScreenNumber {get;set;}
    public int Capacity {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
}


