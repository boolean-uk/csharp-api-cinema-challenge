using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModelsMovie
{
    public class InputMovieDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int RuntimeMins { get; set; }
    }
}
