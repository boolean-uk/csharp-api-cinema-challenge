using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screenings
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }

        [ForeignKey("Movies")]
        public int MoviesId { get; set; }
        public DateTime StartedAt { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime CreatedAt { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime UpdatedAt { get; set; }

    }
}
