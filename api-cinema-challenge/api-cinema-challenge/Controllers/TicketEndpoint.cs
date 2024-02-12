

using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Models.PayLoad;
using api_cinema_challenge.Helpers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("");

            customers.MapPost("tickets/{customerId}/screenings/{screeningId}", PostTicket);
            customers.MapGet("tickets/{customerId}/screenings/{screeningId}", GetAllTickets);
            //customers.MapPut("/{id}", ReadATicket);
            //customers.MapPut("/{id}", UpdateTicket);
            //customers.MapDelete("/{id}", DeleteTicket);
        }

        /// <summary>
        /// Fetches CustomerID, ScreeningID and the number of seats from the request and creates a new ticket with the given information
        /// </summary>
        /// <param name="repository">Repository</param>
        /// <param name="model">Model with the number of tickets</param>
        /// <returns>A payload with "success" as status and a TicketDTO with id, numSeats, CreatedAt and UpdatedAt</returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostTicket(IRepository<Ticket> ticketRepo, IRepository<Customer> customerRepo, IRepository<Screening> screeningRepo, int customerId, int screeningId, TicketPost model)
        {
            var customer = await customerRepo.SelectById(customerId);
            var screening = await screeningRepo.SelectById(screeningId);
            var ticketDTO = new TicketDTO();
            var payload = new PayLoad1<TicketDTO>
            {
                data = ticketDTO,
            };

            // Check if customer and screening exist
            if (customer == null || screening == null)
            {
                payload.status = "Customer or Screening not found";
                return TypedResults.NotFound(payload);
            }

            if (model.NumSeats <= 0)
            {
                payload.status = "Number of seats must be greater than 0";
                return TypedResults.BadRequest(payload);
            }

            var ticket = DTOHelper.MapToEntity<Ticket>(model, "create");
            ticket.CustomerId = customerId;
            ticket.ScreeningId = screeningId;
            var insertedTicket = await ticketRepo.Insert(ticket);
            ticketDTO = DTOHelper.MapToDTO<TicketDTO>(insertedTicket);
            payload.data = ticketDTO;

            return TypedResults.Created($"/{payload.data.Id}", payload);
        }

        /// <summary>
        /// Get a list of every ticket a customer has booked for a screening.
        /// </summary>
        /// <param name="repository"></param>
        /// <returns>A payload with "success" as status and an array of tickets based on the customerId and ScreeningId</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllTickets(IRepository<Ticket> ticketRepo, IRepository<Customer> customerRepo, IRepository<Screening> screeningRepo, int customerId, int screeningId)
        {
            // Find the customer and screening
            var customer = await customerRepo.SelectById(customerId);
            var screening = await screeningRepo.SelectById(screeningId);
            IEnumerable<TicketDTO> ticketDTOs = new List<TicketDTO>();
            var payload = new PayLoad1<IEnumerable<TicketDTO>>
            {
                data = ticketDTOs
            };

            // Check if customer and screening exist
            if (customer == null || screening == null)
            {
                payload.status = "Customer or Screening not found";
                return TypedResults.NotFound(payload);
            }

            // Find tickets booked by the customer for the given screening
            var tickets = await ticketRepo.SelectWhere(ticket => ticket.CustomerId == customerId && ticket.ScreeningId == screeningId);
            ticketDTOs = tickets.Select(c => DTOHelper.MapToDTO<TicketDTO>(c));
            payload.data = ticketDTOs;
            payload.status = tickets.Any() ? "success" : "not found";

            if (payload.status == "success")
            {
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound(payload);
            }
        }

        private static Task ReadATicket(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task UpdateTicket(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task DeleteTicket(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
