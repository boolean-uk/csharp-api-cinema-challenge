using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("num_seat")]
        public int numSeat { get; set; }

        [Column("customer_id")]
        public int customerId { get; set; }

        [Column("screen_id")]
        public int screeningId { get; set; }
        [Column("created_time")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("utdated_time")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Customer? Customer { get; set; }
        public Screening? Screening { get; set; }

    }
}
