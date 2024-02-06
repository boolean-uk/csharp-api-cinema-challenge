using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table ("ticket")]
    public class Ticket
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column("num_seats")]
        public int NumSeats { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column ("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
