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

            tickets.MapPost("/{id}", AddTicket);
            tickets.MapGet("", GetTickets);
            tickets.MapPut("/{id}", UpdateTicket);
            tickets.MapDelete("/{id}", DeleteTicket);
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

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateTicket(IRepository<Ticket> ticketRepository, IRepository<Screening> screeningRepository, int ticketId, int numberOfSeats)
        {
            var ticket = await ticketRepository.Get(ticketId);
            if (ticket == null)
            {
                return TypedResults.NotFound($"Ticket with id {ticketId} was not found");
            }

            Screening? screening = await screeningRepository.Get(ticket.ScreeningId);

            int changedNumberOfSeats = numberOfSeats - ticket.NumberOfSeats;
            if ((screening.AvailableSeats - changedNumberOfSeats) < 0)
            {
                return TypedResults.BadRequest($"Screening does not have enough seats for {numberOfSeats} seats. Only {screening.AvailableSeats} seats are available");
            }

            screening.AvailableSeats -= changedNumberOfSeats;
            ticket.NumberOfSeats = numberOfSeats;

            await screeningRepository.Update(screening);
            var changedTicket = await ticketRepository.Update(ticket);

            return TypedResults.Created($"/{ticketId}", Ticket.ToDTO(changedTicket));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteTicket(IRepository<Ticket> repository, int ticketId)
        {
            var deletedTicket = await repository.Delete(ticketId);
            if (deletedTicket == null)
            {
                return TypedResults.NotFound($"Screening with id {ticketId} was not found");
            }

            return TypedResults.Ok(Ticket.ToDTO(deletedTicket));
        }
    }
}