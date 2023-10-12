using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models.Ticket
{
    public class Ticket
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [JsonIgnore]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
    }
} 