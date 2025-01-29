using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.DTOs;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customers = app.MapGroup("customers");
            customers.MapGet("/customers", GetCustomers);
            customers.MapPost("/create/{id}", CreateCustomer);
            customers.MapPut("/update/{id}", UpdateCustomer);
            customers.MapDelete("/delete/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetCustomers(IRepository customerRepo)
        {

            var customers = await customerRepo.GetCustomers();

            if (customers == null)

            {
                return TypedResults.NotFound("Could not find any customers");

            }

            var customerDto = customers.Select(c => new CustomerDTO
            {

                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,

            });

            return TypedResults.Ok(customerDto);


        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository customerRepo, CreateCustomerDTO customerDto)
        {
            if (customerDto == null)
            { 
            
                return Results.BadRequest("Invalid data for customer");
            }


            Customer customer = new Customer

            {
                Name = customerDto.Name,
                Email = customerDto.Email,
                Phone = customerDto.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };

            var createdCustomer = await customerRepo.CreateCustomer(customer);

            if (createdCustomer == null)
            {
                return Results.BadRequest("Customer could not be created");
            
            }

            var responseDto = new CustomerDTO
            {
                Id = createdCustomer.Id,
                Name = createdCustomer.Name,
                Email = createdCustomer.Email,
                Phone = createdCustomer.Phone,
                CreatedAt = createdCustomer.CreatedAt,
                UpdatedAt = createdCustomer.UpdatedAt,

            };

            return Results.Created($"/api/customers/{createdCustomer.Id}", responseDto);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(IRepository customerRepo, CreateCustomerDTO customerDto, int customerId)
        {
            Customer customerToUpdate = new Customer

            {
                Name = customerDto.Name,
                 Email = customerDto.Email,
                Phone = customerDto.Phone,
            };

            var updatedCustomer = await customerRepo.UpdateCustomer(customerId, customerToUpdate);

            var responseDto = new CustomerDTO

            {
                Id = updatedCustomer.Id,
                Name = updatedCustomer.Name,
                Email = updatedCustomer.Email,
                Phone = updatedCustomer.Phone,
                CreatedAt = updatedCustomer.CreatedAt,
                UpdatedAt = updatedCustomer.UpdatedAt
            };
            return TypedResults.Ok(responseDto);

        }
            
        
   

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository customerRepo, int customerId)
        {
            var customer = await customerRepo.GetCustomerById(customerId);

            if (customer == null)

            {
                return TypedResults.NotFound("Movie not found");

            }

            await customerRepo.DeleteCustomer(customerId);
            return TypedResults.Ok(customer);



        }




    }
}
