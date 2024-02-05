using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");
            cinema.MapGet("customers", GetAllCustomers);
            cinema.MapPost("customers", CreateCustomer);
            cinema.MapPut("customers/{id}", UpdateCustomer);
            cinema.MapDelete("customers/{id}", DeleteCustomer);
        }

        public static async Task<IResult> GetAllCustomers(ICinemaRepository repository)
        {
            var customers = await repository.GetAllCustomers();
            return TypedResults.Ok(new CustomerResponseDTO("success", customers));
        }

        public static async Task<IResult> CreateCustomer(CreateCustomerPayload payload, ICinemaRepository repository)
        {
            if (string.IsNullOrEmpty(payload.Name))
            {
                return TypedResults.BadRequest("Name is required");
            }
            if (string.IsNullOrEmpty(payload.Email))
            {
                return TypedResults.BadRequest("Email is required");
            }
            if (string.IsNullOrEmpty(payload.Phone))
            {
                return TypedResults.BadRequest("Phone is required");
            }
            var customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone, payload);
            return TypedResults.Ok(new CustomerResponseDTO("success", new List<Customer>(){customer}));
        }

        public static async Task<IResult> UpdateCustomer(int id, UpdateCustomerPayload payload, ICinemaRepository repository)
        {
            if (string.IsNullOrEmpty(payload.Name))
            {
                return TypedResults.BadRequest("Name is required");
            }
            if (string.IsNullOrEmpty(payload.Email))
            {
                return TypedResults.BadRequest("Email is required");
            }
            if (string.IsNullOrEmpty(payload.Phone))
            {
                return TypedResults.BadRequest("Phone is required");
            }
            var customer = await repository.UpdateCustomer(id, payload.Name, payload.Email, payload.Phone, payload);
            if (customer == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new CustomerResponseDTO("success", new List<Customer>(){customer}));
        }

        public static async Task<IResult> DeleteCustomer(int id, ICinemaRepository repository)
        {
            var deleted = await repository.DeleteCustomer(id);
            if (!deleted)
            {
                return TypedResults.NotFound();
            }
            var customers = await repository.GetAllCustomers();
            return TypedResults.Ok(new CustomerResponseDTO("success", customers));
        }
    }
}