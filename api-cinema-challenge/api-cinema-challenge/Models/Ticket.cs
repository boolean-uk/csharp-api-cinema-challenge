using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("screening_id"), ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        [Column("customer_id"), ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Column("numSeats")]
        public int NumSeats { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
