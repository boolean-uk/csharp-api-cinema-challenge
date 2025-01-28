using api_cinema_challenge.DTO;
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
    }
    
    [ProducesResponseType(typeof(BaseResponse<IEnumerable<CustomerResponse>>), StatusCodes.Status200OK)]
    private static async Task<IResult> GetCustomers(IRepository<Customer> repository, IMapper mapper)
    {
        var customers = await repository.GetAll();
        var response = new BaseResponse<IEnumerable<CustomerResponse>>(
            "success",
            mapper.Map<IEnumerable<CustomerResponse>>(customers)
            );
        
        return TypedResults.Ok(response);
    }
}