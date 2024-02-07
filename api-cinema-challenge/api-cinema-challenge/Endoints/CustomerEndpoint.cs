using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer");

            // Customer endpoints
            customerGroup.MapGet("/customers" , GetCustomers);
            customerGroup.MapGet("/customers/{id}" , GetCustomerById);
            customerGroup.MapPost("/customers" , CreateCustomer);
            customerGroup.MapPut("/customers/{id}" , UpdateCustomer);
            customerGroup.MapDelete("/customers/{id}" , DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            return TypedResults.Ok(await repository.GetAllCustomers());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomerById(ICustomerRepository repository , int id)
        {
            var customer = await repository.GetCustomer(id);
            if(customer == null)
            {
                return Results.NotFound($"Customer with ID {id} not found.");
            }
            return Results.Ok(customer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository , CustomerDto customerDto)
        {
            var customer = await repository.CreateCustomer(customerDto.Name , customerDto.Email , customerDto.Phone);
            return Results.Created($"/customers/{customer.Id}" , customer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository repository , int id , CustomerDto customerDto)
        {
            var customer = await repository.UpdateCustomer(id , customerDto.Name , customerDto.Email , customerDto.Phone);
            if(customer == null)
            {
                return Results.NotFound($"Customer with ID {id} not found.");
            }
            return Results.Ok(customer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository repository , int id)
        {
            var customer = await repository.DeleteCustomer(id);
            if(customer == null)
            {
                return Results.NotFound($"Customer with ID {id} not found.");
            }
            return Results.Ok(customer);
        }
    }
}
