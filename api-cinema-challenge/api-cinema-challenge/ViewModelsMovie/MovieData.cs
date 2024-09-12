using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModelsMovie
{
    public class MovieData
    {
        public int id { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public MovieData(Movie movie)
        {
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
