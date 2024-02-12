using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer");

            customerGroup.MapGet("", GetCustomers);
            customerGroup.MapPost("", CreateCustomer);
            customerGroup.MapPut("{id}", UpdateCustomer);
            customerGroup.MapDelete("", DeleteCustomer);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            IEnumerable<Customer> customer = await repository.Get();
            if (customer == null) return TypedResults.NotFound();
            return TypedResults.Ok(customer);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerDto customerDto)
        {
            if (customerDto.Name.Trim().Count() == 0 &&
                customerDto.Phone.Trim().Count() == 0 &&
                customerDto.Email.Trim().Count() == 0) return TypedResults.BadRequest();

            Customer customer = Service.CustomerService.toCustomer(customerDto);
            Customer result = await repository.Create(customer);
            return TypedResults.Created($"cusomter/{result.Id}", result);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerDto customerDto)
        {
            Customer customer = await repository.Get(id);
            if ( customer == null ) return TypedResults.NotFound();

            if (customerDto.Name.Trim().Count() == 0 &&
                customerDto.Phone.Trim().Count() == 0 &&
                customerDto.Email.Trim().Count() == 0) return TypedResults.BadRequest();

            customer = Service.CustomerService.updateCustomer(customer, customerDto);
            Customer result = await repository.Update(customer);

            return TypedResults.Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            Customer customer = await repository.Get(id);
            if (customer == null) return TypedResults.NotFound();

            Customer result = await repository.Delete(customer);
            return TypedResults.Ok(result);
        }
    }
}
