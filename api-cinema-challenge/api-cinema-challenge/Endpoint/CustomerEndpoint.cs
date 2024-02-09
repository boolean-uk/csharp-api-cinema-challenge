using System.Runtime.CompilerServices;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoint
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer/");

            customerGroup.MapGet("get_all", GetCustomers);
            customerGroup.MapPost("create", CreateCustomer);
            customerGroup.MapPut("update/{id}", UpdateCustomer);
            customerGroup.MapDelete("delete/{id}", DeleteCustomer);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            var customers = await repository.Get();
            
            List<CustomerDTO> customersDTO = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                customersDTO.Add(new CustomerDTO()
                {
                    Name = customer.Name, Email = customer.Email, Phone = customer.Phone
                });
            }

            return TypedResults.Ok(customersDTO);
        }

        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, string name, string email, string phone)
        {
            Customer customer = new Customer()
            {
                Name = name, Email = email, Phone = phone,
                TimeCreated = DateTime.UtcNow, TimeUpdated = DateTime.UtcNow
            };

            var acceptedCustomer = await repository.Insert(customer);

            return TypedResults.Ok(acceptedCustomer);
        }

        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, string name, string email, string phone)
        {
            Customer customer = new Customer()
            {
                Id = id,
                Name = name,
                Email = email,
                Phone = phone,
                //TODO FIX TIMECREATED
                //currently when updating timecreated does not remain, and turns into -infinity
                TimeUpdated = DateTime.UtcNow
            };

            var acceptedCustomer = await repository.Update(customer);

            return TypedResults.Ok(acceptedCustomer);
        }

        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var acceptedCustomer = await repository.Delete(id);

            return TypedResults.Ok(acceptedCustomer);
        }
    }
}
