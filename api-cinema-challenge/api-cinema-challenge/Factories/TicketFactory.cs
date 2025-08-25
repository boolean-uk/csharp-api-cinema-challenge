using api_cinema_challenge.DTOs.Ticket;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.StaticAssets;

namespace api_cinema_challenge.Factories
{
    public static class TicketFactory
    {
        public static Ticket TicketFromPostDto(TicketPostDto dto, int customerId, int screeningId)
        {
            var ticket = new Ticket();

            ticket.CustomerId = customerId;
            ticket.ScreeningId = screeningId;
            ticket.NumSeats = dto.NumSeats;
            ticket.CreatedAt = DateTime.UtcNow;
            ticket.UpdatedAt = DateTime.UtcNow;

            return ticket;
        }

        public static TicketDto DtoFromTicket(Ticket ticket) 
        { 
            var dto = new TicketDto();

            dto.Id = ticket.Id;
            dto.NumSeats = ticket.NumSeats;
            dto.CreatedAt = ticket.CreatedAt;
            dto.UpdatedAt = ticket.UpdatedAt;

            return dto;
        }
    }
}
