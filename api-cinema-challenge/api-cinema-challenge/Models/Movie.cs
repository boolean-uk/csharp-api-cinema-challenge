using api_cinema_challenge.DOTs.MovieDTOs;
using api_cinema_challenge.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movie")]
    public class Movie 
    {
        [Key]
        [Column("movie_id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtime_mins")]
        public int RunTimeMins { get; set; }
        [Column("screenings")]
        public List<Screening> Screenings { get; set; } = new List<Screening>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public Movie(MoviePost movie)
        {
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RunTimeMins = movie.RunTimeMins;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Movie()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
