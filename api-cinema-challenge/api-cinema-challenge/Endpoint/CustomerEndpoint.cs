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
                    Id = customer.Id, Name = customer.Name, Email = customer.Email, Phone = customer.Phone,
                    TimeCreated = customer.TimeCreated, TimeUpdated = customer.TimeUpdated

                });
            }

            return TypedResults.Ok(customersDTO);
        }

        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerInputDTO customerDTO)
        {
            Customer customer = new Customer()
            {
                Name = customerDTO.Name, Email = customerDTO.Email, Phone = customerDTO.Phone,
                TimeCreated = DateTime.UtcNow, TimeUpdated = DateTime.UtcNow
            };

            var acceptedCustomer = await repository.Insert(customer);

            return TypedResults.Ok(acceptedCustomer);
        }

        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerInputDTO customerDTO)
        {
            var existingData = await repository.GetById(id);

            if (existingData == null) return TypedResults.NotFound();

            existingData.TimeUpdated = DateTime.UtcNow;
            if (customerDTO.Name != "string") existingData.Name = customerDTO.Name;
            if (customerDTO.Email != "string") existingData.Email = customerDTO.Email;
            if (customerDTO.Phone != "string") existingData.Phone = customerDTO.Phone;

            Customer acceptedCustomer = await repository.Update(existingData);

            return TypedResults.Ok(acceptedCustomer);
        }

        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var acceptedCustomer = await repository.Delete(id);

            return TypedResults.Ok(acceptedCustomer);
        }
    }
}
