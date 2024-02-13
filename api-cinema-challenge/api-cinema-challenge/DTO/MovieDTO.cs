using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MovieDTO : BaseDTO
    {
        public MovieDTO(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
