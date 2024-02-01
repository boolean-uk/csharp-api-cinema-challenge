

using api_cinema_challenge.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints {
    public static class CustomerEndpoints {

        public static void ConfigureCustomerEndpoints(this WebApplication app) {
            var customers = app.MapGroup("/customer");

            customers.MapGet("/", GetCustomers);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        { 
            return TypedResults.Ok();
        }
    }
}