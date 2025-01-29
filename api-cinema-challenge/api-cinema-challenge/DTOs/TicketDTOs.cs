using System;

namespace api_cinema_challenge.DTOs;



public class GetTicketDTO
{
    public int Id {get;set;}
    public int NumSeats {get;set;}
    public int PersonId {get;set;}
    public int ScreenMovieId {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    public GetCustomerDTO Customer {get;set;}
}

public class CreateTicketDTO
{
    public int NumSeats {get;set;}
    public int PersonId {get;set;}
    public int ScreenMovieId {get;set;}
}