using System;

namespace api_cinema_challenge.DTOs;

public class CreateMovieDTO
{
    public string Title {get;set;}
    public string Rating {get;set;}
    public string Description {get;set;}
    public int RuntimeMins {get;set;}
}


public class GetMovieDTO
{
    public int Id {get;set;}
    public string Title {get;set;}
    public string Rating {get;set;}
    public string Description {get;set;}
    public int RuntimeMins {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    public List<GetMovieScreenMovieDTO> ScreenMovies {get;set;}
    
}

public class GetScreenMovieGetMovieDTO
{
    public int Id {get;set;}
    public string Title {get;set;}
    public string Rating {get;set;}
    public string Description {get;set;}
    public int RuntimeMins {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}  
}

