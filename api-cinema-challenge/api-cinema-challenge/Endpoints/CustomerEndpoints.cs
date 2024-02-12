using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("Cinema");

            cinemaGroup.MapGet("customer", GetCustomers);
            cinemaGroup.MapGet("customer/{id}", GetACustomer);
            cinemaGroup.MapPost("customer/{id}", CreateCustomer);
            cinemaGroup.MapDelete("customer/{id}", DeleteCustomer);
            cinemaGroup.MapPut("customer/{id}", UpdateCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            var customers = await repository.GetCustomers();
            List<CustomerDTO> dtoCustomers = new List<CustomerDTO>();

            foreach(var customer in customers)
            {
                CustomerDTO customerDTO = new CustomerDTO()
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    CreatedAt = customer.CreatedAt,
                    UpdatedAt = customer.UpdatedAt
                };
                dtoCustomers.Add(customerDTO);
            }
            return TypedResults.Ok(dtoCustomers);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetACustomer(ICustomerRepository repository, int id)
        {
            var customers = await repository.GetCustomerById(id);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = customers.Name,
                Email = customers.Email,
                PhoneNumber = customers.PhoneNumber,
                CreatedAt = customers.CreatedAt,
                UpdatedAt = customers.UpdatedAt
            };
            return TypedResults.Ok(customerDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, Customer customer)
        {
            Customer createCustomer = new Customer()
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow                
            };
            var aCustomer = await repository.CreateCustomer(createCustomer);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = aCustomer.Name,
                Email = aCustomer.Email,
                PhoneNumber = aCustomer.PhoneNumber
            };
            return TypedResults.Ok(customerDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int id)
        {
            var customer = await repository.GetCustomerById(id);
            await repository.DeleteCustomer(id);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
            return TypedResults.Ok(customerDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository repository, int id, Customer customer)
        {
            var aCustomer = await repository.UpdateCustomer(id, customer);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = aCustomer.Name,
                Email = aCustomer.Email,
                PhoneNumber = aCustomer.PhoneNumber
            };
            return TypedResults.Ok(customerDTO);
        }

    }
}
