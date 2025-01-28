using api_cinema_challenge.DTO.Requests;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var c = app.MapGroup("/customers");
            c.MapPost("/", CreateCustomer);
            c.MapGet("/", GetCustomers);
            c.MapPut("/{id}", UpdateCustomer);
            c.MapDelete("/{id}", DeleteCustomer);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateCustomer(IRepository<Customer> repository, IMapper mapper, CustomerRequestDto customerDto)
        {
            var customer = mapper.Map<Customer>(customerDto);
            var createdCustomer = await repository.Insert(customer);
            await repository.Save();
            var response = new Payload { Status = "success", Data = createdCustomer };
            return TypedResults.Created($"/customers/{createdCustomer.Id}", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetCustomers(IRepository<Customer> repository, IMapper mapper)
        {
            var customers = await repository.Get();
            var customerDtos = mapper.Map<IEnumerable<CustomerResponseDto>>(customers);
            var response = new Payload { Status = "success", Data = customerDtos };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, IMapper mapper, int id, CustomerUpdateDto customerDto)
        {
            var customer = await repository.GetById(id);
            if (customer == null)
            {
                var response = new Payload { Status = "error: Customer not found" };
                return TypedResults.NotFound(response);
            }
            if (customerDto.Name != null) customer.Name = customerDto.Name;
            if (customerDto.Email != null) customer.Email = customerDto.Email;
            if (customerDto.Phone != null) customer.Phone = customerDto.Phone;
            await repository.Update(customer);
            await repository.Save();
            var customerResponse = mapper.Map<CustomerResponseDto>(customer);
            var responseOk = new Payload { Status = "success", Data = customerResponse };
            return TypedResults.Ok(responseOk);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, IMapper Mapper, int id)
        {
            var customer = await repository.GetById(id);
            if (customer == null)
            {
                var response = new Payload { Status = "error: Customer not found" };
                return TypedResults.NotFound(response);
            }
            await repository.Delete(id);
            await repository.Save();
            var customerResponse = Mapper.Map<CustomerResponseDto>(customer);
            var responseOk = new Payload { Status = "success", Data = customerResponse };
            return TypedResults.Ok(responseOk);
        }


    }
}
