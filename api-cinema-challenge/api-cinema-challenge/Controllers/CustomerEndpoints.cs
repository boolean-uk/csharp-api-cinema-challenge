using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Payloads;
using api_cinema_challenge.Repositories.customer;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customers = app.MapGroup("/customers");

            customers.MapPost("", CreateCustomer);
            customers.MapGet("", GetAllCustomers);
            customers.MapPut("/{id}", UpdateCustomerById);
            customers.MapDelete("/{id}", DeleteCustomerById);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private async static Task<IResult> CreateCustomer(ICustomerRepository repository, CustomerPayload payload)
        {
            if (payload.CheckPayload() != string.Empty)
            {
                return TypedResults.BadRequest(payload.CheckPayload());
            }

            var newCustomer = await repository.Add(payload.Name, payload.Email, payload.Phone);
            return newCustomer == null ? TypedResults.BadRequest() : TypedResults.Created($"/customers/{newCustomer.Id}", new CustomerDTO(newCustomer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private async static Task<IResult> GetAllCustomers(ICustomerRepository repository)
        {
            List<Customer> allCustomers = await repository.GetAll();
            List<CustomerDTO> resultCustomers = new List<CustomerDTO>();
            if (allCustomers.Count == 0) { return TypedResults.NotFound("No customers where found"); }

            foreach (var customer in allCustomers)
            {
                resultCustomers.Add(new CustomerDTO(customer));
            }
            return TypedResults.Ok(resultCustomers);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private async static Task<IResult> UpdateCustomerById(ICustomerRepository repository, int id, CustomerPayload payload)
        {
            if (payload.CheckPayload() != string.Empty)
            {
                return TypedResults.BadRequest(payload.CheckPayload());
            }

            var updateCustomer = await repository.Update(id, payload.Name, payload.Email, payload.Phone);
            return updateCustomer == null ?
                TypedResults.NotFound($"Customer not found with id {id}") :
                TypedResults.Created($"/customers/{updateCustomer.Id}", updateCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteCustomerById(ICustomerRepository repository, int id)
        {
            if (await repository.Get(id) == null) { return TypedResults.NotFound($"Customer not found with id {id}"); }

            var deletedCustomer = await repository.Delete(id);

            //TODO Check for error
            return TypedResults.Ok(deletedCustomer);
        }


    }
}
