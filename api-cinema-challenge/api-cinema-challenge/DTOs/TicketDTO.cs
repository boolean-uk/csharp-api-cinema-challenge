using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public class TicketResponseDTO
    {
        public int id { get; set; }
        public int numSeats { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ScreeningResponseDTO screening { get; set; }
        public CustomerDTO customer { get; }
        public TicketResponseDTO(Ticket ticket)
        {
            id = ticket.Id;
            numSeats = ticket.NumSeats;
            createdAt = ticket.CreatedAt;
            updatedAt = ticket.UpdatedAt;
            screening = new ScreeningResponseDTO(ticket.Screening);
            customer = new CustomerDTO(ticket.Customer);
        }
    }
}
