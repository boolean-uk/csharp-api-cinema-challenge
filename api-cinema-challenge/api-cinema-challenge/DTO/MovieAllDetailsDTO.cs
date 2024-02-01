using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MovieAllDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public MovieAllDetailsDTO(Movie movie)
        {
            Id = movie.MovieId;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            Runtime = movie.RuntimeMins;
            CreatedAt = movie.Created_at;
            UpdatedAt = movie.Updated_at;
        }

    }
}
