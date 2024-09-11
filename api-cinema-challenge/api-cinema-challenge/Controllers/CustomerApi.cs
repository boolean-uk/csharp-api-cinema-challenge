using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customers = app.MapGroup("customers");
            customers.MapPost("/", CreateCustomer);
            customers.MapGet("/", GetAllCustomers);
            customers.MapPut("/", UpdateCustomer);
            customers.MapDelete("/", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(IRepository repository)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustomer(IRepository repository)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            try
            {
                Payload<List<CustomerDTO>> payload = new Payload<List<CustomerDTO>>();
                payload.data = repository.GetCustomers();
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest();
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateCustomer(IRepository repository, string name, string email, string phone)
        {
            try
            {
                Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
                payload.data =  repository.CreateCustomer(name, email, phone);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest();
            }
            catch
            {
                return TypedResults.BadRequest();
            }

        }
    }
}
