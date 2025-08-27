using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this WebApplication app)
    {
        app.MapGet("/customers", [Authorize] async ([FromServices] ICustomerRepository repo) =>
        {
            var customers = await repo.GetAllAsync();
            return Results.Ok(customers);
        })
        .WithTags("Customers");

        app.MapGet("/customers/{id}", [Authorize] async (int id, [FromServices] ICustomerRepository repo) =>
        {
            var customer = await repo.GetByIdAsync(id);
            return customer is not null ? Results.Ok(customer) : Results.NotFound();
        })
        .WithTags("Customers");

        app.MapPost("/customers", [Authorize] async (Customer customer, [FromServices] ICustomerRepository repo) =>
        {
            var createdCustomer = await repo.CreateAsync(customer);
            return Results.Created($"/customers/{createdCustomer.Id}", createdCustomer);
        })
        .WithTags("Customers");

        app.MapPut("/customers/{id}", [Authorize] async (int id, Customer customer, [FromServices] ICustomerRepository repo) =>
        {
            var updatedCustomer = await repo.UpdateAsync(id, customer);
            return updatedCustomer is not null ? Results.Ok(updatedCustomer) : Results.NotFound();
        })
        .WithTags("Customers");

        app.MapDelete("/customers/{id}", [Authorize] async (int id, [FromServices] ICustomerRepository repo) =>
        {
            var deleted = await repo.DeleteAsync(id);
            return deleted ? Results.Ok() : Results.NotFound();
        })
        .WithTags("Customers");
    }
}
