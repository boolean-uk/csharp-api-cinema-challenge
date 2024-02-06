using api_cinema_challenge.Application.Enums;

namespace api_cinema_challenge.Presentation.DTOs.Movies
{
    public class AddMovieDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public RatingsEnum Ratings { get; set; }
        public int RuntimeMins { get; set; }
    }
}
