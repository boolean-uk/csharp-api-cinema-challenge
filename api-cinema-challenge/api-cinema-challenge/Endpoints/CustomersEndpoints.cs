using System.Runtime.CompilerServices;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
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
            //customers.MapPost("/", InsertCustomer);
            //customers.MapPut("/{id}", UpdateCustomer);
            //customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> customerRepository, IMapper mapper)
        {
            try
            {
                var customers = await customerRepository.Get();

                var response = mapper.Map<CustomerDTO>(customers);

                return TypedResults.Created($"https://localhost:7195/customers/{response.Id}", response);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
