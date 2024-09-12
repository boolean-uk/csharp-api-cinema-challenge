using System.ComponentModel.DataAnnotations;
using api_cinema_challenge.ViewModelsScreening;

namespace api_cinema_challenge.ViewModelsMovie
{
    public class InputCreateMovieDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int RuntimeMins { get; set; }
        [Required]
        public InputScreeningDTO[] screenings { get; set; }
    }
}
