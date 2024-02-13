using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO.DTO_Movie
{
    public class MovieDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string Description { get; set; }
        public int runtimeMins { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public MovieDTO(Movie movie)
        {
            id = movie.id;
            title = movie.title;
            rating = movie.rating;
            Description = movie.Description;
            runtimeMins = movie.runtimeMins;
            createdAt = movie.createdAt;
            updatedAt = movie.updatedAt;
        }


    }
}