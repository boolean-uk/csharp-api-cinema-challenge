using api_cinema_challenge.DTOs.ScreeningDTOs;

namespace api_cinema_challenge.DTOs.MovieDTOs
{
    public class MoviePostDto
    {
        public required string Title { get; set; }
        public required string Rating { get; set; }
        public required string Description { get; set; }
        public required int RuntimeMins { get; set; }

        // optional screenings for a movie
        public List<ScreeningPostDto>? Screenings { get; set; }

    }
}
