using api_cinema_challenge.Models.Screening;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Movie
{
    [NotMapped]
    public class MoviePost
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int RuntimeMins { get; set; }

        public IEnumerable<ScreeningPost> screenings { get; set; } 
    }
}