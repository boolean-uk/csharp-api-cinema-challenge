using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModels
{
    public class MovieDTO
    {
        public int id {  get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public MovieDTO(Movie movie)
        {
            this.id = movie.Id;
            this.title = movie.Title;
            this.rating = movie.Rating;
            this.description = movie.Description;
            this.runtimeMins = movie.RuntimeMins;
            this.createdAt = movie.CreatedAt;
            this.updatedAt = movie.UpdatedAt;
        }
    }
}
