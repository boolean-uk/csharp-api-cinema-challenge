using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("num_seats")]
        public int NumSeats { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
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
    public class TicketOutput
    {
        public string status { get; }
        public TicketResponseDTO data { get; }
        public TicketOutput(string status, Ticket data)
        {
            this.status = status;
            this.data = new TicketResponseDTO(data);
        }
    }

    public class TicketListOutput
    {
        public string status { get; }
        public ICollection<TicketResponseDTO> data { get; }
        public TicketListOutput(string status, ICollection<Ticket> tickets)
        {
            this.status = status;
            data = new List<TicketResponseDTO>();
            foreach (Ticket ticket in tickets)
            {
                data.Add(new TicketResponseDTO(ticket));
            }
        }
    }
    public record TicketPayload(int NumSeats);
}
