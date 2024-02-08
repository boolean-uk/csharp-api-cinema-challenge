using api_cinema_challenge.Models.DatabaseModels;
using api_cinema_challenge.Models.Dto;
using api_cinema_challenge.Models.Dto.GenericDto;
using api_cinema_challenge.Models.Input;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace api_cinema_challenge.Endpoint
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app) 
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerInput input)
        {
            var customers = await repository.GetAll();
            DateTime creationTime = DateTime.UtcNow;

            var entity = new Customer()
            {
                Id = (customers.Count() == 0 ? 0 : customers.Max(patient => patient.Id) + 1),
                Name = input.Name,
                Email = input.Email,
                Phone = input.Phone,
                CreatedAt =creationTime,
                UpdateddAt = creationTime
            };
            repository.Insert(entity);
            return TypedResults.Created($"/{entity.Id}", entity);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            var result = await repository.GetAll();

            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (var item in result)
            {
                CustomerDto customerDto = CustomerDtoFactory(item);
                customerDtos.Add(customerDto);
            }
            //Payload<IEnumerable<Customer>> payload = new Payload<IEnumerable<Customer>>();
            //payload.data = result;
            Payload<List<CustomerDto>> payload = new Payload<List<CustomerDto>>();
            payload.data = customerDtos;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var customer = await repository.GetById(id);
            if (customer == null)
            {
                return TypedResults.NotFound("Customer not found.");
            }
            var result = repository.Delete(id);
            return result != null ? TypedResults.Ok(result) : Results.NotFound();
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerInput input)
        {
            var entity = await repository.GetById(id);
            if (entity == null)
            {
                return TypedResults.NotFound(id);
            }

            DateTime updateTime = DateTime.UtcNow;

            entity.Name = input.Name != null ? input.Name : entity.Name;
            entity.Email = input.Email != null ? input.Email : entity.Email;
            entity.Phone = input.Phone != null ? input.Phone : entity.Phone;
            entity.UpdateddAt = updateTime;
            repository.Update(entity);
            return TypedResults.Created($"/{entity.Id}", entity);
        }

        private static CustomerDto CustomerDtoFactory(Customer customer)
        {
            CustomerDto customerDto = new CustomerDto()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                CreatedAt = customer.CreatedAt,
                UpdateddAt = customer.UpdateddAt
            };
            return customerDto;
        }
    }
}
