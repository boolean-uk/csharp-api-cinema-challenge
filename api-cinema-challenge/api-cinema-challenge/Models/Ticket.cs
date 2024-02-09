using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {

        [Column("ticket_id")]
        public int TicketId { get; set; }

        [Column ("customer_id")]
        [ForeignKey("customers")]
        public int CustomerId { get; set; }

        [Column("screening_id")]
        [ForeignKey("screenings")]
        public int ScreeningId { get; set; }

        [Column("seat_number")]
        public int SeatNumber { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}
