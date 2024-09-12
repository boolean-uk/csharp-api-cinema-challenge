using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsTicket
{
    public class TicketData
    {
        public int id { get; set; }
        public int numSeats { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public TicketData(Ticket ticket)
        {
            this.id = ticket.Id;
            this.numSeats = ticket.NumSeats;
            this.createdAt = ticket.CreatedAt;
            this.updatedAt = ticket.UpdatedAt;
        }
    }
}
