

using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("", CreateCustomer);
            customers.MapGet("", ReadAllCustomers);
            customers.MapPut("/{id}", ReadACustomer);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        private static Task CreateCustomer(HttpContext context)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> ReadAllCustomers(IRepository<Customer> repository)
        {
            var response = await repository.ReadAll();
            return TypedResults.Ok(response);
        }

        private static Task ReadACustomer(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task UpdateCustomer(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task DeleteCustomer(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
