using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTOS;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var books = app.MapGroup("customers");
            books.MapGet("/customers", GetCustomers);
            books.MapPost("/books/{id}", CreateCustomer);
            books.MapPut("/books{id}", UpdateCustomer);
            books.MapDelete("/books{id}", DeleteCustomer);
        }


    }
}
