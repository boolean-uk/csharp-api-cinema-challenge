using api_cinema_challenge.DataTransfer.Requests;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("/customers");

            customers.MapPost("/", Create);
            customers.MapGet("/", GetAll);
            customers.MapPut("/{id}", Update);
            customers.MapDelete("/{id}", Delete);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Customer> repository, CustomerPostRequest customer)
        {
            var newCustomer = new Customer()
            {
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await repository.Create(newCustomer);
            return TypedResults.Created($"/{newCustomer.Id}", newCustomer); 
        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Customer> repository)
        {
            var entities = await repository.GetAll();
            List<Object> results = new List<Object>();

            foreach (var entity in entities)
            {
                results.Add(new { Name = entity.Name, Email = entity.Email, Phone = entity.Phone });
            }

            return TypedResults.Ok(results);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Update(IRepository<Customer> repository, int id, CustomerPostRequest customer)
        {
            var entity = await repository.GetById(id);

            entity.Name = !string.IsNullOrEmpty(customer.Name) ? customer.Name : entity.Name;
            entity.Phone = !string.IsNullOrEmpty(customer.Phone) ? customer.Phone : entity.Phone;
            entity.Email = !string.IsNullOrEmpty(customer.Email) ? customer.Email : entity.Email;
            entity.UpdatedAt = DateTime.UtcNow;

            var result = await repository.Update(entity);

            return result != null ? TypedResults.Ok(new { Name = result.Name, Phone = result.Phone, Email = result.Email ,UpdatedAt = result.UpdatedAt}) : TypedResults.BadRequest("Couldn't save to the database?!");
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Delete(IRepository<Customer> repository, int id)
        {
            var entity = await repository.GetById(id);
            var result = await repository.Delete(entity);

            return result != null ? TypedResults.Ok(new { Name = result.Name, Phone = result.Phone, Email = result.Email, UpdatedAt = result.UpdatedAt }) : TypedResults.BadRequest("Object wasnt deleted?!");
        }
    }
}
