using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer").RequireAuthorization();

            customerGroup.MapPost("/", AddCustomer);
            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);

        }

        // Adding Authorize
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> AddCustomer(IRepository repository, CustomerPost customer)
        {
            var results = await repository.GetCustomers();
            if (results.Any(x => x.Name.Equals(customer.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Results.BadRequest("Customer with provided name already exists");
            }
            Customer entity = new Customer();
            entity.Name = customer.Name;
            entity.Email = customer.Email;
            entity.Phone = customer.Phone;
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await repository.AddCustomer(entity);

            return TypedResults.Created($"https://localhost:7195/customer/{entity.Id}", new { Name = customer.Name, Email = customer.Email, Phone = customer.Phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            var results = await repository.GetCustomers();
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerPut customer)
        {
            var entity = await repository.GetCustomerId(id);

            if (customer.Name != null) entity.Name = customer.Name;
            if (customer.Email != null) entity.Email = customer.Email;
            if (customer.Phone != null) entity.Phone = customer.Phone;
            entity.UpdatedAt = DateTime.UtcNow;
            entity.CreatedAt = DateTime.UtcNow;

            await repository.UpdateCustomer(id, entity);

            return TypedResults.Created($"https://localhost:7195/customer/{entity.Id}", new { Name = customer.Name, Email = customer.Email, Phone = customer.Phone, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var entity = await repository.DeleteCustomer(id);
            return TypedResults.Ok(entity);
        }
       
    }
}
