using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;

namespace api_cinema_challenge.Controllers
{

    public static class CustomerEndpoint {

        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            //customerGroup.MapGet("/", GetAllCustomers);
            // customerGroup.MapPost("/", AddCustomer);
            // customerGroup.MapPut("/{id}", EditCustomer);
            // customerGroup.MapDelete("/{id}", DeleteCustomer);

        }

    }



}
