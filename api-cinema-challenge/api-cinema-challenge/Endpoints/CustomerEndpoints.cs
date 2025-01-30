using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories.GenericRepositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customers = app.MapGroup("/customers");
            customers.MapPost("/", CreateCustomer);
            customers.MapGet("/", GetAllCustomers);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);

        }

        // Create a Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(Customer customer, IRepository<Customer> repository)
        {
            await repository.AddAsync(customer);
            return TypedResults.Created($"/customers/{customer.Id}", new { status = "success", data = customer });
        }

        // Get all Customers
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var customers = await repository.GetAllAsync();
            return TypedResults.Ok(new { status = "success", data = customers });
        }

        // Update a Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(int id, Customer customer, IRepository<Customer> repository)
        {
            var existingCustomer = await repository.GetByIdAsync(id);
            if (existingCustomer == null)
                return TypedResults.NotFound();

            existingCustomer.Name = customer.Name;
            existingCustomer.Email = customer.Email;
            existingCustomer.Phone = customer.Phone;

            await repository.UpdateAsync(existingCustomer);
            return TypedResults.Created($"/customers/{id}", new { status = "success", data = existingCustomer });
        }

        // Delete a Customer
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(int id, IRepository<Customer> repository)
        {
            var customer = await repository.GetByIdAsync(id);
            if (customer == null)
                return TypedResults.NotFound();

            await repository.DeleteAsync(id);
            return TypedResults.Ok(new { status = "success", data = customer });
        }
    }
}
