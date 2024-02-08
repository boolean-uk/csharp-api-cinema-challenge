using api_cinema_challenge.Models.Post;
using api_cinema_challenge.Models.Types;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class CustomerEndpoint
{
    public static void ConfigureCustomerEndpoint(this WebApplication app)
    {
        var customerGroup = app.MapGroup("customer");

        customerGroup.MapPost("/", CreateCustomer);
        customerGroup.MapGet("/", GerCustomers);
        customerGroup.MapPut("/{id}", UpdateCustomer);
        customerGroup.MapDelete("/{Id}", DeleteCustomer);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, PostCustomer customer)
    {
        var newCustomer = new Customer()
        {
            Name = customer.Name,
            Email = customer.Email,
            Phone = customer.Phone,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
        var result = await repository.Create(newCustomer);
        return TypedResults.Created($"/{result.Id}", result);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GerCustomers(IRepository<Customer> repository)
    {
        return TypedResults.Ok(await repository.GetAll());
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, PostCustomer customer)
    {
        var updatedCustomer = await repository.GetById(id);
        if (updatedCustomer == null)
        {
            return TypedResults.NotFound("Unable to find the customer!");
        }
        updatedCustomer.Name = customer.Name;
        updatedCustomer.Email = customer.Email;
        updatedCustomer.Phone = customer.Phone;
        updatedCustomer.UpdatedAt = DateTime.UtcNow;
        var result = await repository.Update(updatedCustomer);
        if (result == null)
        {
            return TypedResults.BadRequest("Failed to update the customer!");
        }
        return TypedResults.Ok(result);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
    {
        var deletedCustomer = await repository.Delete(id);
        if (deletedCustomer == null)
        {
            return TypedResults.NotFound("Unable to find the customer!");
        }
        return TypedResults.Ok(deletedCustomer);
    }
}
