using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customers = app.MapGroup("/customers");
            customers.MapGet("", GetAllCustomers);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRepository customerRepository)
        {
            try
            {
                var result = await customerRepository.GetAllCustomers();
                return TypedResults.Ok(result);

            }
            catch (Exception ex)
            {

                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
