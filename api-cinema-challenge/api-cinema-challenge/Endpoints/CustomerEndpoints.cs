

using System.Reflection.Metadata.Ecma335;
using api_cinema_challenge.Data.DTO;
using api_cinema_challenge.Data.Payload;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints {
    public static class CustomerEndpoints {

        public static void ConfigureCustomerEndpoints(this WebApplication app) {
            var customers = app.MapGroup("/customers");

            customers.MapGet("/", GetCustomers);
            customers.MapGet("/{id}", GetCustomer);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapPost("/", CreateCustomer);
            customers.MapDelete("/{Id}", DeleteCustomer);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        { 
            var customers = await repository.GetAllCustomers();
            if(customers == null || customers.Count() == 0) {
                return Results.NoContent();
            }
            return TypedResults.Ok(CustomerDTO.FromRepository(await repository.GetAllCustomers()));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomer(ICustomerRepository repository, int Id) {
            var customer = await repository.GetCustomer(Id);
            if(customer == null)
                return Results.NotFound("No customer with ID: " + Id + " Found");
            return TypedResults.Ok(new CustomerDTO(customer));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, CreateCustomerPayload payload) {
            if(payload.Name == null)
                return Results.BadRequest("Name cannot be null");
            if(payload.Email == null)
                return Results.BadRequest("Email cannot be null");
            if(payload.Phone == null)
                return Results.BadRequest("Phone cannot be null");
            var customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone);
            return TypedResults.Created("Created", new CustomerDTO(customer));
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository repository, int Id, UpdateCustomerPayload payload) {
            if(Id <= 0)
                return Results.BadRequest("Id must be positive");
            var customer = await repository.GetCustomer(Id);
            Customer newCustomer = new Customer() 
                {
                    Id = customer.Id,
                    Name = customer.Name, 
                    Email = customer.Email,
                    Phone = customer.Phone, 
                    CreatedAt = customer.CreatedAt, 
                    UpdatedAt = customer.UpdatedAt, 
                    Tickets = customer.Tickets
                };
            if(customer == null)
                return Results.NotFound("No customer with ID: " + Id + " Found");
            if(customer.Name != payload.Name && payload.Name != null) {
                newCustomer.Name = payload.Name;
            }
            if(customer.Email != payload.Email && payload.Email != null) {
                newCustomer.Email = payload.Email;
            }
            if(customer.Phone != payload.Phone && payload.Phone != null) {
                newCustomer.Phone = payload.Phone;
            }

            var updated = await repository.UpdateCustomer(Id, customer, newCustomer);
            return TypedResults.Ok(new CustomerDTO(updated));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int Id)
        { 
            var customers = await repository.GetAllCustomers();
            if(customers == null || customers.Count() == 0) {
                return Results.NoContent();
            }
            return TypedResults.Ok(CustomerDTO.FromRepository(await repository.GetAllCustomers()));
        }
    }
}