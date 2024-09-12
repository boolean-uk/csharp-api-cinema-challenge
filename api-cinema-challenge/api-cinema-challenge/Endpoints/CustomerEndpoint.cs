
using api_cinema_challenge.Models;
using api_cinema_challenge.Payloads;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapPost("/CreateCustomer", CreateCustomer);
            customerGroup.MapGet("/GetAllCustomers", GetCustomers);
            customerGroup.MapPut("/UpdateCustomer/{id}", UpdateCustomerById);
            customerGroup.MapDelete("DeleteCustomer/{id}", DeleteCustomerById);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomerById(IRepository repository, int customerId)
        {
            try
            {
                return TypedResults.Ok(await repository.DeleteCustomer(customerId));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomerById(IRepository repository, int customerId, CustomerPayload payload)
        {
            try
            {
                var result = await repository.UpdateCustomer(customerId, payload);
                return TypedResults.Created($"http://localhost:7195/customers/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
         
            return TypedResults.Ok(await repository.GetCustomers());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPayload payload)
        {
            try
            {
                var result = await repository.CreateCustomer(payload);
                return TypedResults.Created($"http://localhost:7195/customers/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
