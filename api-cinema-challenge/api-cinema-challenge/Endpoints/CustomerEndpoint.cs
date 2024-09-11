using api_cinema_challenge.DTO;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Npgsql.Replication;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customers = app.MapGroup("customers");
            customers.MapGet("", GetAllCustomers);
            customers.MapPost("", CreateCustomer);
            customers.MapPut("", UpdateCustomer);
            customers.MapDelete("", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            var customers = await repository.GetAllCustomers();

            var customersDTO = (from customer in customers select customer.ToCustomerDTO()).ToList();

            Payload<List<CustomerDTO>> payload = new() { Status = "success", Data = customersDTO };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel customerPost)
        {

            var customer = await repository.CreateCustomer(customerPost.ToCustomer());

            Payload<CustomerDTO> payload = new () { Status = "success", Data = customer.ToCustomerDTO() };

            return TypedResults.Created("", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, CustomerUpdateModel customerUpdate)
        {
            var customer = await repository.GetACustomer(customerUpdate.Id);

            if (!string.IsNullOrEmpty(customerUpdate.Name))
            {
                customer.Name = customerUpdate.Name;
            }

            if (!string.IsNullOrEmpty(customerUpdate.Email))
            {
                customer.Email = customerUpdate.Email;
            }

            if (!string.IsNullOrEmpty(customerUpdate.PhoneNr))
            {
                customer.PhoneNr = customerUpdate.PhoneNr;
            }

            customer.UpdatedAt = DateTime.UtcNow;

            await repository.UpdateCustomer(customer);

            Payload<CustomerDTO> payload = new() { Status = "success", Data = customer.ToCustomerDTO() };

            return TypedResults.Created("", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int customerId)
        {
            var customer = await repository.DeleteCustomer(customerId);

            Payload<CustomerDTO> payload = new() {Status = "success", Data=customer.ToCustomerDTO() };

            return TypedResults.Ok(payload);
        }
    }
}
