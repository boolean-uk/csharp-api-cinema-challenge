using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("number_of_seats")]
        public int numSeats { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAT { get; set; }

        [Column("screening_id")]
        public int ScreeningID { get; set; }
        [Column("customer_id")]
        public int CustomerID { get; set; }
    }
}
