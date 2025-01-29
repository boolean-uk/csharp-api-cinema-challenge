using System;
using Microsoft.AspNetCore.SignalR;

namespace api_cinema_challenge.DTOs;

public class CustomerDTOs
{

}

public class CreateCustomerDTO
{
    public string Name {get;set;}
    public string Email {get;set;}
    public string Phone {get;set;}
}


public class GetCustomerDTO
{
    public int Id {get;set;}
    public string Email {get;set;}
    public string Name {get;set;}
    public string Phone {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
}
