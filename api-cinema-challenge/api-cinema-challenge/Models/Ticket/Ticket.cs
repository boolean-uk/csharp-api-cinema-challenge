using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models.Ticket
{
    public class Ticket
    {
        public int id { get; set; }
        public int numSeats { get; set; }
       
        [JsonIgnore]
        [ForeignKey("Customer")]
        public int customerId { get; set; }
       
        [JsonIgnore]
        [ForeignKey("Screening")]
        public int screeningId { get; set; }
       
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
