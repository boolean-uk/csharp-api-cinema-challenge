using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{

    [Table("ticket")]
    public class Ticket
    {
        [Column("id")]
        public int id { get; set; }

        [Column("screening_id")]
        public int screeningId { get; set; }

        [Column("customer_id")]
        public int customerId { get; set; }

        [Column("number_of_seats")]
        public int numbSeats { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; }

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }
    }
}
