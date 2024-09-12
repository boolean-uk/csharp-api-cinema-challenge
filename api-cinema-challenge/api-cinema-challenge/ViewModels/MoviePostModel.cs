using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.ViewModels
{
    public class MoviePostModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int RuntimeMins { get; set; }
        public List<ScreeningPostModel> Screenings { get; set; }
    }
}
