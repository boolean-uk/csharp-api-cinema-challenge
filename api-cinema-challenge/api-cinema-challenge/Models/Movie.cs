using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtime_minutes")]
        public int RuntimeMins { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        public ICollection <Screening> screenings { get; set; }
    }

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

    public class MovieOutput
    {
        public string status { get; }
        public MovieDTO data { get; }
        public MovieOutput(string status, Movie movie)
        {
            this.status = status;
            data = new MovieDTO(movie);
        }
    }

    public class MovieListOutput
    {
        public string status { get; }
        public ICollection<MovieDTO> data { get; }
        public MovieListOutput(string status, IEnumerable<Movie> movies)
        {
            this.status = status;
            data = new List<MovieDTO>();
            foreach (Movie movie in movies)
            {
                data.Add(new MovieDTO(movie));
            }
        }
    }


    public record MoviePayload(string Title, string Rating, string Description, int RuntimeMins, List<ScreeningPayload>? Screenings);
}
