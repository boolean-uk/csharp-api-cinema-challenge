using api_cinema_challenge.DTOs.Customer;
using api_cinema_challenge.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class CustomerEndpoints
{
    public static void ConfigureCustomerEndpoints(this WebApplication app)
    {
        var customers = app.MapGroup("customers");
        customers.MapPost("/", Create).WithDescription("Create a new customer account.");
        customers.MapGet("/", GetAll).WithDescription("Get a list of every customer.");
        customers.MapPatch("/{id:int}", Update).WithDescription(
            "Update an existing customer. For ease of implementation, all fields are required from the client.");
        customers.MapDelete("/{id:int}", Delete).WithDescription(
            "Delete an existing customer. When deleting data, it's useful to send the deleted record back to the client so they can re-create it if deletion was a mistake.\n");
    }

    [Authorize]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    private static async Task<IResult> Create(IRepository<Customer> customerRepository, CustomerPut customerPut)
    {
        var createTime = DateTime.UtcNow;
        var customer = new Customer
        {
            Email = customerPut.Email,
            Name = customerPut.Name,
            Phone = customerPut.Phone,
            CreatedAt = createTime,
            UpdatedAt = createTime,
        };
        customerRepository.Insert(customer);
        await customerRepository.SaveAsync();
        return Results.Created("/", customer);
    }

    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    private static async Task<IResult> GetAll(IRepository<Customer> customerRepository)
    {
        var result = await customerRepository.GetAllAsync();

        var resultArray = result.ToArray();
        if (resultArray.Length == 0)
        {
            return Results.NoContent();
        }

        return Results.Ok(resultArray);
    }
    
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private static async Task<IResult> Update(IRepository<Customer> customerRepository, int id, CustomerPut customerPut)
    {
        var customer = await customerRepository.GetByIdAsync(id);
        if (customer == null)
        {
            return Results.NotFound("Customer not found");
        }

        customer.Name = customerPut.Name;
        customer.Phone = customerPut.Phone;
        customer.Email = customerPut.Email;
        customer.UpdatedAt = DateTime.UtcNow;

        customerRepository.Update(customer);
        await customerRepository.SaveAsync();
        
        return Results.Ok(customer);
    }

    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private static async Task<IResult> Delete(IRepository<Customer> customerRepository, int id)
    {
        var customer = await customerRepository.GetByIdAsync(id);
        if (customer == null)
        {
            return Results.NotFound("Customer not found");
        }

        customerRepository.Delete(customer);
        await customerRepository.SaveAsync();
        
        return Results.Ok(customer);
    }
}