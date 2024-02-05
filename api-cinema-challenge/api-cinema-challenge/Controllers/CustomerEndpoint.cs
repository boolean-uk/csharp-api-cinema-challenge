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
            customerGroup.MapPost("/{customerId}/screenings/{screeningId}", CreateTicket);
            customerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetAllTickets);
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
            return TypedResults.Created($"/customers/{customer.Id}",customer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRepository customerRepository)
        {
            var customer = GetCustomerDTO.FromRepository(await customerRepository.GetCustomers());
            if(customer == null)
            {
                return TypedResults.BadRequest("No customers found.");
            }
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(ITicketRepository ticketRepository, TicketPostPayload newTicketData)
        {
            //Check that newTicketData has all values
            if (newTicketData.SeatNr < 0 || newTicketData.CustomerId < 0 || newTicketData.ScreeningId < 0)
            {
                return TypedResults.BadRequest("Your booking does not exist.");
            }
            //Create the new ticket
            var ticket = new TicketDTO(await ticketRepository.CreateTicket(newTicketData.SeatNr, newTicketData.ScreeningId, newTicketData.CustomerId));
            //return TypedResults, remember the path and such
            return TypedResults.Created($"/customer/{ticket.CustomerId}/screenings/{ticket.ScreeningId}", ticket);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllTickets(ITicketRepository ticketRepository, int screeningId)
        {
            var ticket = GetTicketDTO.FromRepository(await ticketRepository.GetAllTickets());
            if(ticket == null)
            {
                return TypedResults.BadRequest("No tickets found.");
            }
            return TypedResults.Ok(ticket);
        }
    }
}
