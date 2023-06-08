using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int numSeats { get; set; }

        [ForeignKey("Screening")]

        public int screeningId { get; set; }
        public Screening screening { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [JsonIgnore]

        public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;
    }
}
