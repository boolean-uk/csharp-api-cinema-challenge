using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using System.Numerics;

namespace api_cinema_challenge.Models.DTO.Entities.MoviesAndScreenings
{
    public class MovieOutputDTO
    {
        public MovieOutputDTO(Movie movie)
        {
            this.Id = movie.Id;
            this.Title = movie.Title;
            this.Rating = movie.Rating;
            this.Description = movie.Description;
            this.RuntimeMins = movie.RuntimeMins;
            this.CreatedAt = movie.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
            this.UpdatedAt = movie.UpdatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
