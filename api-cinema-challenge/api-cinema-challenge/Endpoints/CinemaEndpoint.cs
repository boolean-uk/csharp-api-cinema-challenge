using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema/");

            cinemaGroup.MapGet("customers/", GetCustomers);
            cinemaGroup.MapPost("customers/", CreateCustomer);
            cinemaGroup.MapPut("customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("customer/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            Payload<IEnumerable<Customer>> output = new() { data = await repository.Get() };
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CreateCustomerDto newCustomer)
        {
            Payload<Customer> output = new();
            var customers = await repository.Get();
            Customer customer = new();

            customer.Id = customers.Last().Id+1;
            customer.Name = newCustomer.Name;
            customer.Email = newCustomer.Email;
            customer.Phone = newCustomer.Phone;
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;
            output.data = await repository.Create(customer);

            return TypedResults.Created($"/{output.data.Id}",output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, UpdateCustomerDto updateCustomer)
        {
            Payload<Customer> output = new() { data = await repository.GetById(id) };
            var customers = await repository.Get();

            output.data.Name = updateCustomer.Name != null ? updateCustomer.Name : output.data.Name;
            output.data.Email = updateCustomer.Email != null ? updateCustomer.Email : output.data.Email;
            output.data.Phone = updateCustomer.Phone != null ? updateCustomer.Phone : output.data.Phone;
            output.data.UpdatedAt = DateTime.UtcNow;

            repository.Update(output.data);
            return TypedResults.Created($"", output);
        }

        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            Payload<Customer> output = new();
            var customer = await repository.GetById(id);
            if (customer == null)
            {
                output.status = "failed";
                return TypedResults.NotFound(output);
            }
            output.data = await repository.Delete(id);
            if (output.data == null)
            {
                output.status = "failed";
                return TypedResults.NotFound(output);
            }
            return TypedResults.Ok(output);
        }
    }
}
