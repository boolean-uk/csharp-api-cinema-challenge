using api_cinema_challenge.DTOs.Ticket;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketAPI
    {
        public static void ConfigureTicketEndpoints(this WebApplication app)
        {
            var tickets = app.MapGroup("/tickets");
            tickets.MapGet("", GetAllTickets);
            tickets.MapPost("/customer/{id}", CreateTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllTickets(ITicketRepository ticketRepository)
        {
            try
            {

                var result = await ticketRepository.GetAllTickets();

                List<GetTicketDTO> ticketDTOs = new List<GetTicketDTO>();

                foreach (var ticket in result)
                {
                    GetTicketDTO ticketDTO = new GetTicketDTO()
                    {
                        Id = ticket.Id,
                        NumSeats = ticket.NumSeats,
                        CustomerId = ticket.CustomerId,
                        CustomerName = ticket.Customer.Name,
                        ScreeningId = ticket.ScreeningId,
                        ScreeningNumber = ticket.Screening.ScreenNumber,
                        StartAt = ticket.Screening.StartsAt,
                        MovieTitle = ticket.Screening.Movie.Title,
                        CreatedAt = ticket.CreatedAt,
                        UpdatedAt = ticket.UpdatedAt
                    };

                    ticketDTOs.Add(ticketDTO);
                }

                Payload<IEnumerable<GetTicketDTO>> payload = new Payload<IEnumerable<GetTicketDTO>>();
                payload.data = ticketDTOs;
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateTicket(ITicketRepository ticketRepository, ICustomerRepository customerRepository, IScreeningRepository screeningRepository, PostTicketDTO newTicket)
        {
            try
            {

                var customerTarget = await customerRepository.GetCustomerById(newTicket.CustomerId);
                var screeningTarget = await screeningRepository.GetScreeningById(newTicket.ScreeningId);

                if (customerTarget == null || screeningTarget == null)
                {
                    return TypedResults.NotFound($"Customer with id {newTicket.CustomerId} or Screening with id {newTicket.ScreeningId} not found!");
                }

                var ticket = await ticketRepository.CreateTicket(new Ticket()
                {
                    NumSeats = newTicket.NumSeats,
                    CustomerId = newTicket.CustomerId,
                    ScreeningId = newTicket.ScreeningId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                });

                GetTicketDTO ticketDTO = new GetTicketDTO()
                {
                    Id = ticket.Id,
                    NumSeats = ticket.NumSeats,
                    CustomerId = ticket.CustomerId,
                    CustomerName = ticket.Customer.Name,
                    ScreeningId = ticket.ScreeningId,
                    ScreeningNumber = ticket.Screening.ScreenNumber,
                    StartAt = ticket.Screening.StartsAt,
                    MovieTitle = ticket.Screening.Movie.Title,
                    CreatedAt = ticket.CreatedAt,
                    UpdatedAt = ticket.UpdatedAt
                };

                Payload<GetTicketDTO> payload = new Payload<GetTicketDTO>();
                payload.data = ticketDTO;
                payload.status = System.Net.HttpStatusCode.Created;
                var path = $"tickets/{ticket.Id}";

                return TypedResults.Created(path, payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
