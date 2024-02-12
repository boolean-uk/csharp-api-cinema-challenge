using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Customers;
using api_cinema_challenge.Models.Screenings;
using api_cinema_challenge.Models.Tickets;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", GetAll);
            customerGroup.MapPost("/", Create);
            customerGroup.MapPut("/{id}", Update);
            customerGroup.MapDelete("/{id}", Delete);
            customerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetAllTickets);
            customerGroup.MapPost("/{customerId}/screenings/{screeningId}", CreateTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Customer> repository) {
            var cars = await repository.GetAll();
            Payload<IEnumerable<Customer>> payload = new() { Data = cars };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> Create(IRepository<Customer> repository, CustomerInput customer)
        {
            if (customer.Name == null || customer.Email == null || customer.Phone == null)
            {
                Payload<string> errorPayload = new() { Status = "error", Data = "Invalid input." };
                return TypedResults.BadRequest(errorPayload);
            }

            Customer newCustomer = new () { Name = customer.Name, Email = customer.Email, Phone = customer.Phone };
            await repository.Create(newCustomer);

            Payload<Customer> payload = new () { Data = newCustomer };
            return TypedResults.Created($"/{newCustomer.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Update(IRepository<Customer> repository, int id, CustomerInput newData)
        {
            var customer = await repository.GetById(id);

            if (customer == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Customer not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            if (newData.Name == null || newData.Email == null || newData.Phone == null)
            {
                Payload<string> errorPayload = new() { Status = "error", Data = "Invalid input." };
                return TypedResults.BadRequest(errorPayload);
            }

            customer.Update(newData);
            await repository.Update(customer);

            Payload<Customer> payload = new () { Data = customer };
            return TypedResults.Created($"/{customer.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Delete(IRepository<Customer> repository, int id)
        {
            var customer = await repository.GetById(id);

            if (customer == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Customer not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            await repository.Delete(id);

            Payload<Customer> payload = new () { Data = customer };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllTickets(IRepository<Customer> repository, IRepository<Screening> screeningRepository, IRepository<Ticket> ticketRepository, int customerId, int screeningId)
        {
            var customer = await repository.GetById(customerId);
            if (customer == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Customer not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            var screening = await screeningRepository.GetById(screeningId);
            if (screening == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Screening not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            var tickets = await ticketRepository.GetAll();
            Payload<IEnumerable<TicketDto>> payload = new() { Data = tickets.Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId).Select(t => t.ToDto()) };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateTicket(IRepository<Customer> repository, IRepository<Screening> screeningRepository, IRepository<Ticket> ticketRepository, int customerId, int screeningId, TicketInput ticket)
        {
            var customer = await repository.GetById(customerId);
            if (customer == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Customer not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            var screening = await screeningRepository.GetById(screeningId);
            if (screening == null)
            {
                Payload<string> notFoundPayload = new() { Status = "error", Data = "Screening not found." };
                return TypedResults.NotFound(notFoundPayload);
            }

            Ticket newTicket = new() { CustomerId = customerId, ScreeningId = screeningId, NumSeats = ticket.NumSeats };
            await ticketRepository.Create(newTicket);

            Payload<TicketDto> payload = new() { Data = newTicket.ToDto() };
            return TypedResults.Created($"/{newTicket.Id}", payload);
        }
    }
}
