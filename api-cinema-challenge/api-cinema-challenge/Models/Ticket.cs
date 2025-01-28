using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int customerId { get; set; }
        public int screeningId { get; set; }
        public int numSeats { get; set; }
        [Column("createdAt", TypeName = "timestamp")]
        public DateTime createdAt { get; set; } = DateTime.Now;
        [Column("updatedAt", TypeName = "timestamp")]
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public Customer Customer { get; set; }
        public Screening Screening { get; set; }
    }
}
