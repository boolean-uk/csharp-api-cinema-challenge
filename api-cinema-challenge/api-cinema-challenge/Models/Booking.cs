using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Screening")]
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [Column("nr_of_tickets")]
        public int NrOfTickets { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
