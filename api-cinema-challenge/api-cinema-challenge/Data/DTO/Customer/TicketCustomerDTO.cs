using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {
    public class TicketCustomerDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ScreeningDTO Screening { get; set; }

        public TicketCustomerDTO(Ticket ticket) {
            Id = ticket.Id;
            NumSeats = ticket.NumSeats;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
            Screening = new ScreeningDTO(ticket.Screening);
        }

        public static ICollection<TicketCustomerDTO> FromRepository(ICollection<Ticket> tickets) {
            List<TicketCustomerDTO> result = new List<TicketCustomerDTO>();
            foreach (var ticket in tickets)
            {
                result.Add(new TicketCustomerDTO(ticket));
            }
            return result;
        }
    }
}