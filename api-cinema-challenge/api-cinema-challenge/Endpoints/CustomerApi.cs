using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customers = app.MapGroup("customers");
            customers.MapGet("/", GetCustomers);
            customers.MapGet("/{id}", GetCustomerById);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
            customers.MapPost("/", CreateCustomer);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            Response<IEnumerable<CustomerDTO>> response = new();
            var customers = await repository.GetAll();
            var customerResponse = customers.Select(c => new CustomerDTO(c));
            response.Data = customerResponse;
            return TypedResults.Ok(response);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomerById(IRepository<Customer> repository, int id)
        {
            Response<IEnumerable<CustomerDTO>> response = new();
            List<CustomerDTO> customerResponse = new();
            var customer = await repository.GetById(id);
            customerResponse.Add(new CustomerDTO(customer));
            response.Data = customerResponse;
            return TypedResults.Ok(response);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerPayload model)
        {
            Response<IEnumerable<CustomerDTO>> response = new();
            List<CustomerDTO> customerResponse = new();

            var updateCustomer = await repository.GetById(id);
            updateCustomer.Name = model.Name;
            updateCustomer.Email = model.Email;
            updateCustomer.PhoneNumber = model.Phone;
            updateCustomer.UpdatedAt = DateTime.UtcNow;

            updateCustomer = await repository.Update(updateCustomer);

            customerResponse.Add(new CustomerDTO(updateCustomer));
            response.Data = customerResponse;
            return TypedResults.Ok(response);
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            Response<IEnumerable<CustomerDTO>> response = new();
            List<CustomerDTO> customerResponse = new();
            var deleteCustomer = await repository.Delete(id);
            customerResponse.Add(new CustomerDTO(deleteCustomer));
            response.Data = customerResponse;
            return TypedResults.Ok(response);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerPayload model)
        {
            var customers = await repository.GetAll();
         
            if (customers.Any(c => c.Name == model.Name)) 
            {
                return TypedResults.BadRequest($"{model.Name} already exists");
            }

            Response<IEnumerable<CustomerDTO>> response = new();
            List<CustomerDTO> customerResponse = new();
            var addCustomer = new Customer() { Name = model.Name, Email = model.Email, PhoneNumber = model.Phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            addCustomer = await repository.Add(addCustomer);
            customerResponse.Add(new CustomerDTO(addCustomer));
            response.Data = customerResponse;
            return TypedResults.Ok(response);
        }


    }
}
