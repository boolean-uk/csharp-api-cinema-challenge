using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {

        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer/");

            customerGroup.MapPost("", CreateCustomer);
            customerGroup.MapGet("", GetAllCustomers);
            //customerGroup.MapPut("{id}", UpdateCustomer);
            //customerGroup.MapDelete("{id}", DeleteCustomer);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> customerRepo, PostCustomer model)
        {
            var entity = new Customer() {Name = model.Name, Phone=model.Phone };
            var create = await customerRepo.Create(entity);

            var result = new CustomerDTO() 
            {
                Id = create.Id,
                Name = create.Name,
                Phone = create.Phone,
                CreatedAt = create.CreatedAt,
                UpdatedAt = create.UpdatedAt,
            };

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> GetAllCustomers(IRepository<Customer> customerRepo)
        {
            var result = await customerRepo.GetAll();
            Payload<IEnumerable<Customer>> payload = new Payload<IEnumerable<Customer>>();
            payload.data = result;
            return TypedResults.Ok(payload);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> customerRepo, int id, PutCustomer model)
        {
            return TypedResults.Ok("");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> customerRepo, int id)
        {
            var result = await customerRepo.Delete(id);
            if (result == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(result);
        }

    }
}
