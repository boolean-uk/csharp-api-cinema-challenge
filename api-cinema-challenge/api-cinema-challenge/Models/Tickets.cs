using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Tickets
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public int numSeats { get; set; }

        [ForeignKey("Screenings")]
        public int ScreenId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime CreatedAt { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime UpdatedAt { get; set; }

    }
}
