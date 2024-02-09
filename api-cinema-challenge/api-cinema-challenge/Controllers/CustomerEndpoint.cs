using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {

        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer");

            customerGroup.MapPost("/post", CreateCustomer);
            customerGroup.MapGet("/get", GetCustomers);
            customerGroup.MapPut("/update/{Id}", UpdateCustomers);
            customerGroup.MapDelete("/delete/", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository customerRepository, CustomerUpdateDTO payload)
        {
            var customer = new Customer()
            {
                Name = payload.Name,
                Email = payload.Email,
                Phone = payload.Phone
            };
            await customerRepository.CreateCustomer(customer);
      

            var response = new ApiResponse<CustomerUpdateDTO>
            {
                Data = payload,
                Status = "Success"
            };

            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> GetCustomers(ICustomerRepository customerRepository)
        {
            var customers = await customerRepository.GetCustomers();
            List<CustomerDTO> returncustomers = new List<CustomerDTO>();

            foreach (var customer in customers)
            {
                CustomerDTO newCustomer = new CustomerDTO
                {
                    Id= customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    CreatedAt = customer.CreatedAt,
                    UpdatedAt = customer.UpdatedAt,
                };
                returncustomers.Add(newCustomer);
            }

            var response = new ApiResponse<List<CustomerDTO>>
            {
                Data= returncustomers,
                Status = "Success"
            };
            return TypedResults.Ok(response);
        }

        public static async Task<IResult> UpdateCustomers(ICustomerRepository customersRepository, int id, CustomerUpdateDTO payload)
        {

            var customer = await customersRepository.GetCustomerById(id);
            if(customer == null)
            {
                return Results.BadRequest("Id is invalid");
            }

            customer.Name = string.IsNullOrEmpty(payload.Name) ? customer.Name : payload.Name;
            customer.Email = string.IsNullOrEmpty(payload.Email) ? customer.Email : payload.Email;
            customer.Phone = string.IsNullOrEmpty(payload.Phone) ? customer.Phone : payload.Phone;

            await customersRepository.UpdateCustomer(customer);

            CustomerDTO returnCustomer = new CustomerDTO()
            {
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                Id = customer.Id,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt
            };

            var response = new ApiResponse<CustomerDTO>
            {
                Data = returnCustomer,
                Status = "success"
            };
            return TypedResults.Ok(response);
        }

        public static async Task<IResult> DeleteCustomer(ICustomerRepository customerRepository,int id)
        {
            var customer = await customerRepository.GetCustomerById(id);
            CustomerDTO returnCustomer = new CustomerDTO()
            {
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                Id = customer.Id,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt
            };
           await customerRepository.DeleteCustomer(customer);

            var response = new ApiResponse<CustomerDTO>
            {
                Data = returnCustomer,
                Status = "Success"
            };

            return TypedResults.Ok(response);
        } 
    }
}
