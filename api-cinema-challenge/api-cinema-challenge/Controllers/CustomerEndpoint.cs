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
        public static async Task<IResult> AddCustomer(ICustomerRespository repository, CustomerPost customer)
        {
            if (customer == null || customer.Name == null || customer.Email == null || customer.PhoneNumber == null)
            {
                return TypedResults.BadRequest("Invalid input, all fields must be provided");
            }

            Customer newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
            };

            var addedCustomer = await repository.AddCustomer(newCustomer);

            return TypedResults.Created($"/{newCustomer.Id}", addedCustomer.ToDTO());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRespository repository)
        {
            var customers = await repository.GetAllCustomers();
            var customerDTO = new CustomerListDTO { Status = "success", Data = customers };
            return TypedResults.Ok(customerDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(ICustomerRespository repository, int id, CustomerPost customer)
        {
            if (customer == null || customer.Name == null || customer.Email == null || customer.PhoneNumber == null)
            {
                return TypedResults.BadRequest("Invalid input, all fields must be provided");
            }

            var changedCustomer = await repository.UpdateCustomer(id, customer);
            if (changedCustomer == null)
            {
                return TypedResults.NotFound($"Customer with id {id} was not found");
            }

            return TypedResults.Created($"/{changedCustomer.Id}", changedCustomer.ToDTO());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(ICustomerRespository repository, int id)
        {
            var deletedCustomer = await repository.DeleteCustomer(id);
            if (deletedCustomer == null)
            {
                return TypedResults.NotFound($"Customer with id {id} was not found");
            }

            return TypedResults.Ok(deletedCustomer.ToDTO());
        }
    }
}
