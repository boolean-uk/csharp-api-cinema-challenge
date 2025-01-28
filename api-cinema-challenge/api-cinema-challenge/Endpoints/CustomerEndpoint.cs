
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Request;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace workshop.wwwapi.Endpoints
{
    public static class CustomersEndpoint
    {
        public static void ConfigureCustomersEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("/customers"); 
            customers.MapPost("/", CreateACustomer);
            customers.MapGet("/", GetAllCustomers);
            customers.MapPut("/{id}", UpdateACustomer);
            customers.MapDelete("/{id}", DeleteACustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateACustomer(HttpContext context, IRepository<Customers> repo, Create_Customer dto)
        {
            var customer = Create_Customer.create(dto);
            var entity = await repo.CreateEntry(customer);
            return TypedResults.Created(context.Get_endpointUrl(customer.Id), Get_Customer.toPayload(entity));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllCustomers( IRepository<Customers> repo)
        {
            var entries = await repo.GetEntries();
            return TypedResults.Ok(Get_Customer.toPayload(entries));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateACustomer(HttpContext context, IRepository<Customers> repo, int id, Update_Customer dto)
        {
            var ent = await Update_Customer.update(dto, repo, id);
            return TypedResults.Ok(Get_Customer.toPayload(ent));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteACustomer(HttpContext context, IRepository<Customers> repo, int id)
        {
            var ent = await Delete_Customer.delete(repo, id);
            return TypedResults.Created(context.Get_endpointUrl(ent.Id), Get_Customer.toPayload(ent));
        }

    }
}
