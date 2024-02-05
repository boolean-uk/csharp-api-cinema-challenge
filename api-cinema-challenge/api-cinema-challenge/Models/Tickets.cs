using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public record TicketPostPayload(int SeatNr);
    [Table("tickets")]
    public class Tickets
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("seat_nr")]
        public int SeatNr { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Tickets()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
