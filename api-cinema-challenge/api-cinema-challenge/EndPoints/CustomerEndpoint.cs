using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerEndpoint
    {
        public static string error404 = "Does not exist";
        public static void configureCustomerEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("customer");
            group.MapGet("/", GetAllCustomers);
            group.MapPost("/", CreateCustomer);
            group.MapPut("/{id:int}", UpdateCustomer);
            group.MapDelete("/{id:int}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRepository repository)
        {
            var customers = await repository.GetCustomers();
            return TypedResults.Ok(customers);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, CreateCustomerDto model)
        {
            Customer customerCreated = await repository.CreateCustomer(model);
            return TypedResults.Created("", customerCreated);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository repository, int id, CreateCustomerDto model)
        {
            Customer customerUpdated = await repository.UpdateCustomer(id, model);
            if(customerUpdated == null)
            {
                return TypedResults.NotFound(error404);
            }
            return TypedResults.Created("", customerUpdated);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int id)
        {
            Customer customerDeleted = await repository.DeleteCustomer(id);
            if(customerDeleted == null)
            {
                return TypedResults.NotFound(error404);
            }
            return TypedResults.Ok(customerDeleted);
        }
    }
}
