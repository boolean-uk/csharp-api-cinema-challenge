using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]

    public class Movie
    {
        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("movie_tite")]
        public string Title { get; set; }

        [Column("movie_rating")]
        public string Rating { get; set; }

        [Column("movie_description")]
        public string Description { get; set; }

        [Column("movie_runtimeMins")]
        public int RuntimeMins { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Screening> Screenings { get; set; } 

    }
}
