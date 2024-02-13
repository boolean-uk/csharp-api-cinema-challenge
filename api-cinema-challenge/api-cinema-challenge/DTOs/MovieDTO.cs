using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{

    public class MovieDTO
    {
        public int id { get; }
        public string title { get; }
        public string rating { get; }
        public string description { get; }
        public int runtimeMins { get; }
        public DateTime createdAt { get; }
        public DateTime updatedAt { get; }
        public MovieDTO(Movie movie)
        {
            if (movie is null) return;
            id = movie.Id;
            title = movie.Title;
            rating = movie.Rating;
            description = movie.Description;
            runtimeMins = movie.RuntimeMins;
            createdAt = movie.CreatedAt;
            updatedAt = movie.UpdatedAt;
        }

    }
}
