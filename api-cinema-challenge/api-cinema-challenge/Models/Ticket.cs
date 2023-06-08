using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "NumSeats is required")]
        public int NumSeats { get; set; }

        [Required(ErrorMessage = "Screening is required")]
        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [Required(ErrorMessage = "Customer is required")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
