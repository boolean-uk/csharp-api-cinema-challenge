using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Movie is required")]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required(ErrorMessage = "Screen is required")]
        [ForeignKey("Screen")]
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        public DateTime StartsAt { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
