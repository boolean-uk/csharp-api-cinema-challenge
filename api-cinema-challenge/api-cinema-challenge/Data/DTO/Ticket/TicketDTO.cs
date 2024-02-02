using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {

    public class TicketDTO {
        public int Id {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public int ScreeningId {get; set;}
        public int CustomerId {get; set;}
        public ICollection<SeatDTO> Seats {get; set;} = [];

        public TicketDTO(Ticket ticket) {
            Id = ticket.Id;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.CreatedAt;
            ScreeningId = ticket.ScreeningId;
            CustomerId = ticket.CustomerId;
            foreach (Seat seat in ticket.Seats)
            {
                Seats.Add(new SeatDTO(seat));
            }
        }

        public static ICollection<TicketDTO> FromRepository(ICollection<Ticket> ticket) {
            List<TicketDTO> Tickets = new List<TicketDTO>();
            foreach (var t in ticket)
            {
                Tickets.Add(new TicketDTO(t));
            }
            return Tickets;
        }
    }
}