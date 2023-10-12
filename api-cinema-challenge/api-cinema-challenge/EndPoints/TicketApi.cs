using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screen;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models.Ticket;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication application)
        {
            application.MapPost("/customers/{customerId}/screenings/{screeningId}", AddTicket);
            application.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTickets);
        }

        public static async Task<IResult> GetTickets(int customerId, int screeningId, IRepository repository)
        {
            try
            {
                TicketCollectionCreate ticketCollectionCreate = new TicketCollectionCreate();
                ticketCollectionCreate.data = repository.GetTickets().Where(t => t.customerId == customerId && t.screeningId == screeningId).ToList();
                return ticketCollectionCreate.data != null ? Results.Ok(ticketCollectionCreate) : Results.Problem();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddTicket(int customerId, int screeningId, TicketCreate ticketCreate, IRepository repository)
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.customerId = customerId;
                ticket.screeningId = screeningId;
                ticket.numSeats = ticketCreate.numSeats;
                ticket.createdAt = DateTime.UtcNow;
                ticket.updatedAt = DateTime.UtcNow;
                repository.AddTicket(ticket);
                Payload<Ticket> payload = new Payload<Ticket>();
                payload.data = ticket;
                

                return Results.Created("https://localhost:7195/customers", payload);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


    }
}
