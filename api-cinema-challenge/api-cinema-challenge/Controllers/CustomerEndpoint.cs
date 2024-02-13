using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.User_Requests;
using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Payloads;
using workshop.wwwapi.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("cinema/customers");

            customerGroup.MapGet("", GetCustomers);
            customerGroup.MapGet("{id}", GetCustomerByID);
            customerGroup.MapPut("{id}", UpdateCustomer);
            customerGroup.MapPost("", CreateCustomer);
            customerGroup.MapDelete("{id}", DeleteCustomer);
        }

        // --- Customer ---
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            Payload<IEnumerable<CustomerDTO>> payload = new();

            // Create DTO
            List<CustomerDTO> DTOs = new List<CustomerDTO>();
            foreach (var entity in repository.GetAll().Result)
                DTOs.Add(new CustomerDTO(entity));

            payload.data = DTOs;

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomerByID(IRepository<Customer> repository, int id)
        {
            Payload<CustomerDTO> payload = new();
            // Create DTO
            payload.data = new CustomerDTO(repository.GetByID(id).Result);

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerRequest request)
        {

            Payload<CustomerDTO> payload = new();
            Customer entity = new Customer(request);

            entity = await repository.Insert(entity);

            // Create DTO
            payload.data = new CustomerDTO(entity);

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerRequest request)
        {
            Payload<CustomerDTO> payload = new();

            if (repository.GetByID(id).Result == default(Customer))
                return TypedResults.NotFound();

            Customer entity = new Customer(request) {
                Id = id,
                CreatedAt = repository.GetByID(id).Result.CreatedAt, 
                UpdatedAt = DateTime.UtcNow
            };

            entity = await repository.Update(id, entity);

            // Create DTO
            payload.data = new CustomerDTO(entity);

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            Payload<CustomerDTO> payload = new();

            payload.data = new CustomerDTO(await repository.Delete(id));

            return TypedResults.Ok(payload);
        }
    }
}