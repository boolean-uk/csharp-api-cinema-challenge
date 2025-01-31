using System;
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Calls;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;

namespace api_cinema_challenge.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/customers");

        group.MapPost("/", CreateCustomer);
        group.MapGet("/", GetAllCustomers);
        group.MapPut("/{id}", UpdateCustomer);
        group.MapDelete("/{id}", DeleteCustomer);
    }

    public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerPost customerPost, IMapper mapper)
    {
        var response = await repository.Create(mapper.Map<Customer>(customerPost));
        return TypedResults.Created("Created", new Payload<CustomerDTO>(mapper.Map<CustomerDTO>(response)));
    }

    public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository, IMapper mapper)
    {
        try
        {
            var customers = await repository.GetAll();
            return TypedResults.Ok(new Payload<IEnumerable<CustomerDTO>>(mapper.Map<IEnumerable<CustomerDTO>>(customers)));
        }
        catch (Exception e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }

    public static async Task<IResult> UpdateCustomer(int id, IRepository<Customer> repository, CustomerPut customerPut, IMapper mapper)
    {
        var customer = await repository.GetById(id);
        if (customer == null)
        {
            return TypedResults.NotFound($"No entity with id {id} found");
        }

        mapper.Map(customerPut, customer); // Map customerPut to the existing customer entity
        await repository.Update(customer);
        return TypedResults.Ok(new Payload<CustomerDTO>(mapper.Map<CustomerDTO>(customer)));
    }

    public static async Task<IResult> DeleteCustomer(int id, IRepository<Customer> repository, IMapper mapper)
    {
        try
        {
            var customer = await repository.Delete(id);
            return TypedResults.Ok(new Payload<CustomerDTO>(mapper.Map<CustomerDTO>(customer)));
        }
        catch (Exception e)
        {
            return TypedResults.NotFound(e.Message);
        }
    }
}