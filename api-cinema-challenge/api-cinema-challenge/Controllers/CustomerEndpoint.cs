using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("", AddCustomer);
            customers.MapGet("", GetAllCustomers);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddCustomer(IRepository<Customer> repository, CustomerPost customer)
        {
            if (customer == null)
            {
                return TypedResults.BadRequest("Invalid input: missing customer");
            }
            if (string.IsNullOrEmpty(customer.Name))
            {
                return TypedResults.BadRequest("Invalid input: please enter a name");
            }
            if (string.IsNullOrEmpty(customer.Email))
            {
                return TypedResults.BadRequest("Invalid input: please enter an email");
            }
            if (string.IsNullOrEmpty(customer.PhoneNumber))
            {
                return TypedResults.BadRequest("Invalid input: please enter a phone number");
            }

            Customer newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
            };

            var addedCustomer = await repository.Add(newCustomer);

            return TypedResults.Created($"/{newCustomer.Id}", Customer.ToDTO(addedCustomer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var customers = await repository.GetAll();
            return TypedResults.Ok(Customer.ToDTO(customers));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerPost customer)
        {
            if (customer == null)
            {
                return TypedResults.BadRequest("Invalid input: missing customer");
            }

            Customer? oldCustomer = await repository.Get(id);

            if (oldCustomer == null)
            {
                return TypedResults.BadRequest($"Customer with id {id} could not be found");
            }

            if (!string.IsNullOrEmpty(customer.Name)) { oldCustomer.Name = customer.Name; }
            if (!string.IsNullOrEmpty(customer.Email)) {  oldCustomer.Email = customer.Email; }
            if (!string.IsNullOrEmpty(customer.PhoneNumber)) { oldCustomer.PhoneNumber = customer.PhoneNumber; }
            oldCustomer.UpdatedAt = DateTime.UtcNow;

            var changedCustomer = await repository.Update(oldCustomer);

            return TypedResults.Created($"/{id}", Customer.ToDTO(changedCustomer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var deletedCustomer = await repository.Delete(id);
            if (deletedCustomer == null)
            {
                return TypedResults.NotFound($"Customer with id {id} was not found");
            }

            return TypedResults.Ok(Customer.ToDTO(deletedCustomer));
        }
    }
}
