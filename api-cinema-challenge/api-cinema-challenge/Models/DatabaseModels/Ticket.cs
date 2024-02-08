using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DatabaseModels
{
    public class Ticket
    {
        [Column("ticket_id")]
        public int Id { get; set; }
        [Column("customer_id")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Column("screening_id")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        [Column("num_seats")]
        public int NumSeats { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
