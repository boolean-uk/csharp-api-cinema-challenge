using api_cinema_challenge.DTOs.Customers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customer = app.MapGroup("/customers");

            customer.MapPost("/", Create);
            customer.MapGet("/", GetAll);
            customer.MapPut("/{id}", UpdateCustomer);
            customer.MapDelete("/{id}", Delete);
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Customer> customerRepository) 
        {

            var results = await customerRepository.Get();

            return TypedResults.Ok(results);

        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> Create(IRepository<Customer> customerRepository, CustomerPostPut model)
        {
            Customer customer = new Customer()
            {
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var entity = await customerRepository.Insert(customer);
            

            return TypedResults.Created($"", entity);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> customerRepository, int id, CustomerPostPut model)
        {
            var resultGet = await customerRepository.GetOne(id);
            resultGet.Name = model.Name;
            resultGet.Email = model.Email;
            resultGet.Phone = model.Phone;
            resultGet.UpdatedAt = DateTime.UtcNow;

            var result = await customerRepository.Update(resultGet);
            return TypedResults.Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> Delete(IRepository<Customer> customerRepository, int id)
        {
            var result = await customerRepository.Delete(id);
            return TypedResults.Ok(result);
        }
    }
}
