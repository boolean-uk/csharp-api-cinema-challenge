using api_cinema_challenge.DTOs.Screening;

namespace api_cinema_challenge.DTOs.Movie
{
    public class MoviePostDto
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public ICollection<ScreeningPostDto> Screenings { get; set; } = new List<ScreeningPostDto>();
    }
}
