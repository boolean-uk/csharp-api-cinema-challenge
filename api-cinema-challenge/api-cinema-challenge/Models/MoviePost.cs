using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [NotMapped]
    public class MoviePost
    {
        [Required]
        public required string title { get; set; }
        [Required]
        public required string rating { get; set; }
        [Required]
        public required string description { get; set; }
        [Required]
        public required int runtimeMins { get; set; }
        public List<ScreeningPost>? screenings { get; set; }
    }
}
