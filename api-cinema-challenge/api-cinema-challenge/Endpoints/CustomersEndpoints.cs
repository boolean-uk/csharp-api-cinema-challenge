using System.Runtime.CompilerServices;
using api_cinema_challenge.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomersEndpoints
    {
        public static void ConfigureCustomers(this WebApplication app)
        {
            var customers = app.MapGroup("/customers");

            customers.MapGet("/", GetAllCustomers);
            customers.MapPost("/", InsertCustomer);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> GetAllCustomers(IRepository<CustomersEndpoints> customerRepository, IMapper mapper)
        {
            var results = await customerRepository.Get();


        }
    }
}
