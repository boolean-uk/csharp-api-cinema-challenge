using api_cinema_challenge.Models.Types;

namespace api_cinema_challenge.Models.DTOs;

public class TicketDTO
{
    public int Id { get; set; }
    public int NumSeats { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public static TicketDTO ToDTO(Ticket ticket)
    {
        return new TicketDTO()
        {
            Id = ticket.Id,
            NumSeats = ticket.NumSeats,
            CreatedAt = ticket.CreatedAt,
            UpdatedAt = ticket.UpdatedAt,
        };
    }
}
