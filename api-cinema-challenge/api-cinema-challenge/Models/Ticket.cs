using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }

        [Column("created_at", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; }

        public Customer Customer { get; set; }
        public Screening Screening { get; set; }
    }
}
