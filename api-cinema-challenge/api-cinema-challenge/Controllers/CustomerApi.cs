using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerApi
    {
        private static string payloadStatusSuccess = "Success";
        private static string payloadStatusFailure = "Failure";
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
        private static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            try
            {TestInput(id);
                Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
                payload.data = repository.DeleteCustomer(id);
                payload = checkPayload(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustomer(IRepository repository, int customerId, string name, string email, string phone)
        {
            try
            {TestInput(customerId);
                Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
                payload.data = repository.UpdateCustomer(customerId, name, email, phone);
                payload = checkPayload(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
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
                payload = checkPayloadList(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateCustomer(IRepository repository, string name, string email, string phone)
        {
            try
            {
                Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
                payload.data = repository.CreateCustomer(name, email, phone);
                payload = checkPayload(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest(payload);
            }
            catch (Exception ex) 
            {
                return TypedResults.BadRequest(ex);
            }
        }

        private static Payload<CustomerDTO> checkPayload(Payload<CustomerDTO> payload)
        {
            if (payload.data != null)
            {
                payload.status = payloadStatusSuccess;
                return payload;
            }
            else
            {
                payload.status = payloadStatusFailure;
                return payload;
            }
        }

        private static Payload<List<CustomerDTO>> checkPayloadList(Payload<List<CustomerDTO>> payload)
        {
            if (payload.data != null)
            {
                payload.status = payloadStatusSuccess;
                return payload;
            }
            else
            {
                payload.status = payloadStatusFailure;
                return payload;
            }
        }

        private static void TestInput(int input)
        {
            int test = input;
        }

    }
}
