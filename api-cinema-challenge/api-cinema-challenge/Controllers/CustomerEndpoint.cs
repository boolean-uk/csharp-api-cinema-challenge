using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");
            customerGroup.MapGet("", GetCustomers);
          //  customerGroup.MapPost("", CreateCustomer);
            customerGroup.MapGet("/{id}", GetCustomerByID);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
        }

        public static async Task<IResult> GetCustomers(ICustomerRepository customerRepository)
        {
            return TypedResults.Ok(new Payload<IEnumerable<Customer>>() { data = await customerRepository.GetCustomers() }) ;
        }
        /*
        public static async Task<IResult> CreateCustomer(ICustomerRepository customerRepository, CustomerPayload payload)
        {
            if (payload.Name == null || payload.Name == "")
                return TypedResults.BadRequest("Please provide a name");
            if (payload.Email == null || payload.Email == "")
                return TypedResults.BadRequest("Please provide an email");
            if (!payload.Email.Contains('@'))
                return TypedResults.BadRequest("Please provide a valid email");
            if (payload.Phone == null || payload.Phone == "")
                return TypedResults.BadRequest("Please provide a phone number");
            Customer customer = await customerRepository.CreateCustomer(payload.Name, payload.Email, payload.Phone);
            return TypedResults.Created(",", new Payload<Customer>() { data = customer });
        }
        */
        public static async Task<IResult> GetCustomerByID(ICustomerRepository customerRepository, int id)
        {
            Customer? customer = await customerRepository.GetCustomerByID(id);
            if (customer is null) return TypedResults.NotFound($"Customer {id} doesn't exist");
            return TypedResults.Ok(new Payload<Customer>() { data = customer });
        }
        public static async Task<IResult> UpdateCustomer(ICustomerRepository customerRepository, int id, CustomerPayload payload)
        {
            Customer? customer = await customerRepository.GetCustomerByID(id);
            if (customer is null) return TypedResults.NotFound($"Customer {id} doesn't exist");
            Customer updatedCustomer = customerRepository.UpdateCustomer(customer, payload.Name, payload.Email, payload.Phone);
            return TypedResults.Created("", new Payload<Customer>() { data = updatedCustomer });
        }
        public static async Task<IResult> DeleteCustomer(ICustomerRepository customerRepository, int id)
        {
            Customer? customer = await customerRepository.GetCustomerByID(id);
            if (customer is null) return TypedResults.NotFound($"Customer {id} doesn't exist");
            await customerRepository.DeleteCustomer(customer);
            return TypedResults.Ok(new Payload<Customer>() { data = customer });
        }
    }
}
