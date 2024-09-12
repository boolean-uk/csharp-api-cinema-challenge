using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class CustomerEndpoint
{
    
    public static void ConfigureCustomersApi(this WebApplication app)
    {
        var customers = app.MapGroup("customers");

        customers.MapPost("/", AddCustomer);
        customers.MapGet("/", GetCustomers);
        customers.MapPut("/{id}", UpdateCustomer);
        customers.MapDelete("/{id}", DeleteCustomer);
        customers.MapGet("/{id}", GetCustomerById);
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> AddCustomer(IRepository<Customer> repo, CustomerPayload model)
    {
        var timeNow = DateTime.UtcNow;
        var c = new Customer()
        {
            Name = model.Name,
            Email = model.Email,
            PhoneNumber = model.Phone,
            CreatedAt = timeNow,
            UpdatedAt = timeNow
        };
        var result = await repo.Add(c);
        return TypedResults.Created($"/customers/{c.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    private async static Task<IResult> GetCustomers(IRepository<Customer> repo)
    {
        var result = await repo.GetAll();
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> UpdateCustomer(IRepository<Customer> repo, int id, CustomerPayload model)
    {
        var c = await repo.GetById(id);
        c.Name = model.Name;
        c.Email = model.Email;
        c.UpdatedAt = DateTime.UtcNow;
        var result = await repo.Update(c);
        return TypedResults.Created($"/customers/{c.Id}", new ReturnValue("success", result));
    }
    
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
    {
        var c = await repo.GetById(id);
        if (c is null) return TypedResults.NotFound($"Customer with id {id} not found");
        var result = await repo.Delete(c);
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> GetCustomerById(IRepository<Customer> repo, int id)
    {
        var c = await repo.GetById(id);
        return c is null ? TypedResults.NotFound($"Customer with id {id} not found") : TypedResults.Ok(new ReturnValue("success", c));
    }
}