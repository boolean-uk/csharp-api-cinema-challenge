using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customers = app.MapGroup("customers");
            customers.MapGet("", GetAllCustomers);
            customers.MapPost("", CreateCustomer);
            customers.MapPut("", UpdateCustomer);
            customers.MapDelete("", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel customerPost)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, CustomerUpdateModel customerUpdate)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
