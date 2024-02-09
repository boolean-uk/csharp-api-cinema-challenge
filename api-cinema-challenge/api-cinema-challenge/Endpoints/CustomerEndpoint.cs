using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Post;
using api_cinema_challenge.Models.Types;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class CustomerEndpoint
{
    public static void ConfigureCustomerEndpoint(this WebApplication app)
    {
        var customerGroup = app.MapGroup("customers");

        customerGroup.MapPost("/", CreateCustomer);
        customerGroup.MapGet("/", GetCustomers);
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
        Customer result = await repository.Create(newCustomer);
        return TypedResults.Created($"/{result.Id}", new Payload<CustomerDTO>() { Data = CustomerDTO.ToDTO(result) });
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
    {
        var customers = await repository.GetAll();
        var returnList = new List<CustomerDTO>();
        foreach (var customer in customers)
        {
            returnList.Add(CustomerDTO.ToDTO(customer));
        }
        return TypedResults.Ok(new Payload<List<CustomerDTO>>() { Data = returnList });
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, PostCustomer customer)
    {
        var updatedCustomer = await repository.GetById(id);
        if (updatedCustomer == null)
        {
            return TypedResults.NotFound(new Payload<string>() { Status = "fail", Data = "Unable to find the customer!" });
        }
        updatedCustomer.Name = customer.Name;
        updatedCustomer.Email = customer.Email;
        updatedCustomer.Phone = customer.Phone;
        updatedCustomer.UpdatedAt = DateTime.UtcNow;
        var result = await repository.Update(updatedCustomer);
        if (result == null)
        {
            return TypedResults.BadRequest(new Payload<string>() { Status = "fail", Data = "Failed to update the customer!" });
        }
        return TypedResults.Ok(new Payload<CustomerDTO>() { Data = CustomerDTO.ToDTO(result) });
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
    {
        var deletedCustomer = await repository.Delete(id);
        if (deletedCustomer == null)
        {
            return TypedResults.NotFound(new Payload<string>() { Status = "fail", Data = "Unable to find the customer!" });
        }
        return TypedResults.Ok(new Payload<CustomerDTO>() { Data = CustomerDTO.ToDTO(deletedCustomer) });
    }
}
