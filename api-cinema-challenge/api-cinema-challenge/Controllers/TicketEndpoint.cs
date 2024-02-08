using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var tickets = app.MapGroup("tickets");

            tickets.MapPost("", AddTicket);
            tickets.MapGet("", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddTicket(IRepository<Ticket> ticketRepository, 
            IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository,  
            int customerId, int screeningId, int numSeats)
        {
            var customer = await customerRepository.Get(customerId);
            if (customer == null)
            {
                return TypedResults.NotFound($"Customer with id {customerId} was not found");
            }

            var screening = await screeningRepository.Get(screeningId);
            if (screening == null)
            {
                return TypedResults.NotFound($"Screening with id {screeningId} was not found");
            }

            var ticket = new Ticket
            {
                CustomerId = customerId,
                Customer = customer,
                Screening = screening,
                ScreeningId = screeningId,
                NumberOfSeats = numSeats
            };

            var newTicket = await ticketRepository.Add(ticket);

            return TypedResults.Created($"/{customerId}/screenings/{screeningId}", Ticket.ToDTO(newTicket));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTickets(IRepository<Customer> customerRepository, IRepository<Ticket> ticketRepository, int customerId)
        {
            var customer = await customerRepository.Get(customerId);

            if (customer == null)
            {
                return TypedResults.NotFound($"Customer with id {customerId} was not found");
            }

            var allTickets = await ticketRepository.GetAll();
            var tickets = allTickets.Where(x => x.CustomerId == customerId).ToList();

            return TypedResults.Created($"/{customerId}/screenings/", Ticket.ToDTO(tickets));
        }
    }
}