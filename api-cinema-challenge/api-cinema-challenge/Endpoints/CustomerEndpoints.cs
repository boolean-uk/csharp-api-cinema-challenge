

using System.Reflection.Metadata.Ecma335;
using api_cinema_challenge.Data.DTO;
using api_cinema_challenge.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints {
    public static class CustomerEndpoints {

        public static void ConfigureCustomerEndpoints(this WebApplication app) {
            var customers = app.MapGroup("/customer");

            customers.MapGet("/", GetCustomers);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        { 
            var customers = await repository.GetAllCustomers();
            if(customers == null || customers.Count() == 0) {
                return Results.NoContent();
            }
            return TypedResults.Ok(CustomerDTO.FromRepository(await repository.GetAllCustomers()));
        }
    }
}