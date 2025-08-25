using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("ticket_id")]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("customer")]
        public Customer Customer { get; set; }

        [ForeignKey("Screening")]
        [Column("screening_id")]
        public int ScreeningId { get; set; }

        [Column("screening")]
        public Screening Screening { get; set; }

        [Column("ticket_numSeats")]
        public int numSeats { get; set; }

        [Column("ticket_createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("ticket_updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
