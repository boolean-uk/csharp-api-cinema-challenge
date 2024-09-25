using api_cinema_challenge.Controller;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using Microsoft.AspNetCore.Mvc;
using Npgsql.PostgresTypes;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app) {

            var customerGroup = app.MapGroup("customer");

            customerGroup.MapGet("/customers", GetCustomers);
            customerGroup.MapPost("/createcustomer", CreateCustomer);
            customerGroup.MapPost("/updatecustomer/{id}", UpdateCustomer);
            customerGroup.MapDelete("/deletecustomer/{id}", DeleteCustomer);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomers(CustomerService controller)
        {
            var customers = await controller.GetAll();
            if (customers == null)
            {
                return TypedResults.StatusCode(StatusCodes.Status404NotFound);
            }
            return TypedResults.Ok(new ReturnValue("success", customers));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateCustomer(CustomerService service, CustomerPayload payload)
        {
            var customer = await service.Create(payload);
            if (customer == null)
            {
                return TypedResults.StatusCode(StatusCodes.Status404NotFound);
            }
            return TypedResults.Created($"/createcustomer/{customer.Id}", new ReturnValue("success", customer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(CustomerService service, int id, CustomerPayload newCustomer)
        {
            var customer = await service.Update(id, newCustomer);
            if (customer == null)
            {
                return TypedResults.StatusCode(StatusCodes.Status404NotFound);
            }
            return TypedResults.Created($"/updatecustomer/{customer.Id}", new ReturnValue("success", customer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(CustomerService service, int id)
        {
            var customer = await service.Delete(id);
            if (customer == null)
            {
                return TypedResults.StatusCode(StatusCodes.Status404NotFound);
            }
            return TypedResults.Created($"/deletecustomer/{customer.Id}", new ReturnValue("success", customer));
        }
    }

}
