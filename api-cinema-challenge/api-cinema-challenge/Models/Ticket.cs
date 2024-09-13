using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("numSeats")]
        public int NumSeats { get; set; }

        [JsonIgnore]
        [Column("customerid")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [JsonIgnore]
        [Column("screeningid")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }

        [Column("created")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated")]
        public DateTime UpdatedAt { get; set; }
    }
}
