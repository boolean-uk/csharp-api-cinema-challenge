using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapPost("/{customerId}", CreateCustomer);
            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPut("/", UpdateCustomer);
            customerGroup.MapDelete("/", DeleteCustomer);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository customerRepository, NewCustomer newData)
        {
            //Check that newData has all values
            if (newData.Name == null || newData.Email == null || newData.PhoneNr == 0 || newData.ScreeningId == 0)
            {
                return TypedResults.BadRequest("You must enter data for all fields!");
            }
            //Create the new customer
            var customer = new GetCustomerDTO(await customerRepository.CreateCustomer(newData.Name, newData.Email, newData.PhoneNr, newData.ScreeningId));
            return TypedResults.Created($"/{customer.Id}",customer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRepository customerRepository)
        {
            var customer = GetCustomerDTO.FromRepository(await customerRepository.GetCustomers());
            return TypedResults.Ok(customer);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository customerRepository, UpdateCustomer newData, int id)
        {
            //Find customer to update via Id
            Customer? customer = await customerRepository.GetCustomer(id);
            //Check if customer exists
            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with id {id} found.");
            }
            //Check that newData has all values
            if (newData.Name == null || newData.Email == null || newData.PhoneNr == 0 || newData.ScreeningId == 0)
            {
                return TypedResults.BadRequest("You must enter data for all fields!");
            }
            //Run the Update method
            customer = await customerRepository.UpdateCustomer(id, newData.Name, newData.Email, newData.PhoneNr, newData.ScreeningId);
            return TypedResults.Created($"/{customer.Id}", customer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository customerRepository, int id)
        {
            //Check that the customer with that id exists
            Customer? customer = await customerRepository.GetCustomer(id);
            if (customer == null)
            {
                return TypedResults.NotFound($"No movie with id {id} found.");
            }
            //Run the Delete method
            customer = await customerRepository.DeleteCustomer(id);
            return TypedResults.Ok(customer);
        }
    }
}
