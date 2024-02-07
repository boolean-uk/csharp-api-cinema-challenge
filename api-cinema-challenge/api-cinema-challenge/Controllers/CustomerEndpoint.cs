using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.PostModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;

namespace api_cinema_challenge.Controllers
{

    public static class CustomerEndpoint {

        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPost("/", AddCustomer);
            customerGroup.MapPut("/{id}", EditCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);

        }

    
         [ProducesResponseType(StatusCodes.Status200OK)]
         public static async Task<IResult> GetAllCustomers(IRepository repository, int id)
         {
             throw new NotImplementedException();
             //TODO: Return IEnumerable<DTCustomer>
         }

         [ProducesResponseType(StatusCodes.Status201Created)]
         public static async Task<IResult> AddCustomer(IRepository repository, PMScreening model)//TODO: Add PostCustomer model
         {
             throw new NotImplementedException();
             //TODO: Return DTCustomer
         }

         [ProducesResponseType(StatusCodes.Status201Created)]
         public static async Task<IResult> EditCustomer(IRepository repository, int id, PMScreening model)//TODO: Add PostCustomer model
         {
             throw new NotImplementedException();
                 //TODO: Return DTCustomer
             }

             [ProducesResponseType(StatusCodes.Status200OK)]
         public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
         {
             throw new NotImplementedException();
                 //TODO: Return DTCustomer
         }


    }
}
