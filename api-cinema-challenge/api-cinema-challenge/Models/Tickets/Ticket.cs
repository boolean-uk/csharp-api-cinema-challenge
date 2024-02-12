using api_cinema_challenge.Models.Customers;
using api_cinema_challenge.Models.Screenings;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Tickets
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column("screening_id")]
        [ForeignKey("ScreeningId")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [Column("num_seats")]
        public int NumSeats { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public TicketDto ToDto()
        {
            return new TicketDto
            {
                Id = Id,
                NumSeats = NumSeats,
                CreatedAt = CreatedAt,
                UpdatedAt = UpdatedAt
            };
        }
    }
}
