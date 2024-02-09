using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {

        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var TicketGroup = app.MapGroup("ticket");

            TicketGroup.MapPost("/post", CreateTicket);
            TicketGroup.MapGet("/get", GetTickets);
        }



        public static async Task<IResult> CreateTicket(ITicketRepository ticketRepository, int customerId, int screeningId, TicketDTO ticketdto)
        {
            Ticket ticket = await ticketRepository.CreateTicket(ticketdto.NumSeats, customerId, screeningId);

            TicketOutDTO outTicket = new()
            {
                ScreeningId = ticket.ScreeningId,
                NumSeats = ticket.NumSeats,
                CustomerId = customerId,
                Id = ticket.Id,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt,
            };

            var response = new ApiResponse<TicketOutDTO>()
            {
                Data = outTicket,
                Status = "Success"
            };

            return TypedResults.Ok(response);

        }

        public static async Task<IResult> GetTickets(ITicketRepository ticketRepository, int CustomerId, int screeningId)
        {
            var tickets = await ticketRepository.GetTickets(screeningId, CustomerId);
            List<GetTicketDTO> result = new List<GetTicketDTO>();

            foreach (var ticket in tickets)
            {
                result.Add(new GetTicketDTO
                {
                    Id = ticket.Id,
                    NumSeats = ticket.NumSeats,
                    CreatedAt = ticket.CreatedAt,
                    UpdatedAt = ticket.UpdatedAt
                });
                
            }

            var response = new ApiResponse<List<GetTicketDTO>>()
            {
                Data = result,
                Status = "success"
            };

            return TypedResults.Ok(response);
        }


    }
}
