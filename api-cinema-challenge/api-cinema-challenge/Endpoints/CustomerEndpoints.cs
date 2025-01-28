using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class CustomerEndpoints
{
    public static void ConfigureCustomerEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("customers");

        group.MapGet("/", GetCustomers);
        group.MapPost("/", CreateCustomer);

        group.MapGet("/{id}", GetCustomer);
        group.MapPut("/{id}", UpdateCustomer);
        group.MapDelete("/{id}", DeleteCustomer);
    }

    [ProducesResponseType(typeof(BaseResponse<IEnumerable<CustomerResponse>>), StatusCodes.Status200OK)]
    private static async Task<IResult> GetCustomers(IRepository<Customer> repository, IMapper mapper)
    {
        var customers = await repository.GetAll();
        var response = new BaseResponse<IEnumerable<CustomerResponse>>(
            Consts.SuccessStatus,
            mapper.Map<IEnumerable<CustomerResponse>>(customers)
        );

        return TypedResults.Ok(response);
    }

    [ProducesResponseType(typeof(BaseResponse<CustomerResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BaseResponse<>), StatusCodes.Status404NotFound)]
    private static async Task<IResult> GetCustomer(IRepository<Customer> repository, IMapper mapper, int id)
    {
        var customer = await repository.Get(c => c.Id == id);
        if (customer == null) return TypedResults.NotFound(new BaseResponse<object?>(Consts.ErrorStatus, null));

        var response = new BaseResponse<CustomerResponse>(
            Consts.SuccessStatus,
            mapper.Map<CustomerResponse>(customer)
        );

        return TypedResults.Ok(response);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    private static async Task<IResult> CreateCustomer(IRepository<Customer> repository, IMapper mapper,
        [FromBody] CustomerPost body)
    {
        var customer = mapper.Map<Customer>(body);
        await repository.Add(customer);
        var response = new BaseResponse<CustomerResponse>(
            Consts.SuccessStatus,
            mapper.Map<CustomerResponse>(customer)
        );

        return TypedResults.Created($"/customers/{customer.Id}", response);
    }

    [ProducesResponseType(typeof(BaseResponse<CustomerResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(BaseResponse<>), StatusCodes.Status404NotFound)]
    private static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, IMapper mapper, int id,
        [FromBody] CustomerPut body)
    {
        var customer = await repository.Get(c => c.Id == id);
        if (customer == null) return TypedResults.NotFound(new BaseResponse<object?>(Consts.ErrorStatus, null));

        customer.Name = body.Name;
        customer.Email = body.Email;
        customer.Phone = body.Phone;
        await repository.Update(customer);

        var response = new BaseResponse<CustomerResponse>(
            Consts.SuccessStatus,
            mapper.Map<CustomerResponse>(customer)
        );

        return TypedResults.Created("/customers/" + customer.Id, response);
    }

    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
    {
        var customer = await repository.Get(c => c.Id == id);
        if (customer == null) return TypedResults.NotFound(new BaseResponse<object?>(Consts.ErrorStatus, null));

        await repository.Delete(customer);
        return TypedResults.NoContent();
    }
}