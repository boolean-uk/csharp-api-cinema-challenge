using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using System.Net.Sockets;

namespace api_cinema_challenge.Endpoints
{
    public record CustomerPostPayload(string name, string email, string phone);

    public record CustomerUpdatePayload(string? name, string? email, string? phone);

    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapPut("/", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            return TypedResults.Ok(CustomerResponseDTO.FromRepository(await repository.GetCustomers()));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, CustomerPostPayload payload)
        {
            if (payload.name == null || payload.name == "" ||
                payload.email == null || payload.email == "" ||
                payload.phone == null || payload.phone == "")
                return Results.BadRequest("Must have all inputs");

            Customer? customer = await repository.CreateCustomer(payload.name, payload.email, payload.phone);
            if (customer == null)
                return Results.BadRequest("Name already exists");

            CustomerResponseDTO custom = CustomerResponseDTO.FromARepository(customer);
            return TypedResults.Created($"/customers{custom.Status} {custom.Datas}", custom);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public async static Task<IResult> UpdateCustomer(ICustomerRepository repository, CustomerUpdatePayload posted, int id)
        {
            Customer? customer = await repository.GetCustomer(id);
            if (customer == null)
                return Results.NotFound("ID out of scope");

            customer = await repository.UpdateCustomer(customer, posted.name, posted.email, posted.phone);
            if (customer == null)
                return Results.BadRequest("Name already found");

            CustomerResponseDTO custom = CustomerResponseDTO.FromARepository(customer);
            return TypedResults.Created($"/customers{custom.Status} {custom.Datas}", custom);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public async static Task<IResult> DeleteCustomer(ICustomerRepository repository, int id)
        {
            Customer? customer = await repository.GetCustomer(id);
            if (customer == null)
                return Results.NotFound("ID out of scope");

            return TypedResults.Ok(CustomerResponseDTO.FromRepository(await repository.DeleteCustomer(customer)));
        }
    }
}
