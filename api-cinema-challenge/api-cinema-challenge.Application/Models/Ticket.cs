using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Application.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [ForeignKey("Screening")]
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        [ForeignKey("Customer")]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("num_seats")]
        public int NumSeats { get; set; }
        [Column("created_at", TypeName = "date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updated_at", TypeName = "date")]
        public DateTime? UpdatedAt { get; set; }
    }
}
