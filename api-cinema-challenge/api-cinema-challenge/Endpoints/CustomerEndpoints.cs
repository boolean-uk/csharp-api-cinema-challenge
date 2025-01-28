using api_cinema_challenge.DTO;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static string Path { get; private set; } = "customers";
        public static void ConfigureCustomersEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapGet("/", GetCustomers);
            group.MapPost("/", CreateCustomer);
            group.MapGet("/{id}", GetCustomer);
            group.MapPut("/{id}", UpdateCustomer);
            group.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetCustomers(IRepository<Customer, int> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Customer> customers = await repository.GetAll();
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<CustomerView>>(customers) });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetCustomer(IRepository<Customer, int> repository, IMapper mapper, int id)
        {
            try
            {
                Customer customer = await repository.Get(id);
                return TypedResults.Ok(mapper.Map<CustomerView>(customer));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateCustomer(
            IRepository<Customer, int> repository,
            IRepository<Customer, int> customerRepository,
            IMapper mapper,
            CustomerPost entity)
        {
            try
            {
                Customer customer = await repository.Add(new Customer
                {
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email,
                    Phone = entity.Phone,
                });
                return TypedResults.Created($"{Path}/{customer.Id}", new Payload
                {
                    Data = mapper.Map<CustomerView>(customer)
                });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> UpdateCustomer(
            IRepository<Customer, int> repository,
            IRepository<Customer, int> customerRepository,
            IMapper mapper,
            int id,
            CustomerPut entity)
        {
            try
            {
                Customer customer = await repository.Get(id);
                if (entity.FirstName != null) customer.FirstName = entity.FirstName;
                if (entity.LastName != null) customer.LastName = entity.LastName;
                if (entity.Email != null) customer.Email = entity.Email;
                if (entity.Phone != null) customer.Phone = entity.Phone;
                customer = await customerRepository.Update(customer);
                return TypedResults.Created($"{Path}/{customer.Id}", new Payload
                {
                    Data = mapper.Map<CustomerView>(customer)
                });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteCustomer(
            IRepository<Customer, int> repository,
            IRepository<Customer, int> customerRepository,
            IMapper mapper,
            int id)
        {
            try
            {
                Customer customer = await customerRepository.Delete(id);
                return TypedResults.Created($"{Path}/{customer.Id}", new Payload { Data = mapper.Map<CustomerView>(customer) });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
