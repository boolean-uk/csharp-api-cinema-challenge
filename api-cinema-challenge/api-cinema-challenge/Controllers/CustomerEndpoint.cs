using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPut("/{customerId}", UpdateCustomer);
            customerGroup.MapDelete("/{customerId}", DeleteCustomer);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository customerRepository, CustomerPostPayload newData)
        {
            //Check that newData has all values
            if (newData.Name == null || newData.Email == null || newData.PhoneNr == null || newData.ScreeningId == 0)
            {
                return TypedResults.BadRequest("You must enter data for all fields!");
            }
            //Create the new customer
            var customer = new CustomerDTO(await customerRepository.CreateCustomer(newData.Name, newData.Email, newData.PhoneNr, newData.ScreeningId));
            return TypedResults.Created($"/{customer.Id}",customer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRepository customerRepository)
        {
            var customer = GetCustomerDTO.FromRepository(await customerRepository.GetCustomers());
            return TypedResults.Ok(customer);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository customerRepository, CustomerUpdatePayload newData, int id)
        {
            //Find customer to update via Id
            Customer? customer = await customerRepository.GetCustomer(id);
            //Put newData into temporary working variables
            string name = newData.Name;
            string email = newData.Email;
            string phoneNr = newData.PhoneNr;
            int screeningId = (int)newData.ScreeningId;
            //Check if customer exists
            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with id {id} found.");
            }
            //Check that newData has all values, otherwise use old values
            if (name == null || name == "string" || name == string.Empty)
                name = customer.Name;
            if (email == null || email == "string" || email == string.Empty)
                email = customer.Email;
            if (phoneNr == null || phoneNr == "string" || phoneNr == string.Empty)
                phoneNr = customer.PhoneNr;
            if (screeningId == 0)
                screeningId = customer.ScreeningId;
            //Run the Update method
            customer = await customerRepository.UpdateCustomer(id, name, email, phoneNr, screeningId);
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
