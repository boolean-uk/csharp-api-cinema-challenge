using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [Column("movie_id")]
        public int Id { get; set; }

        [Column("movie_title")]
        public string Title { get; set; } = string.Empty;

        [Column("movie_rating")]
        public string Rating { get; set; } = string.Empty;

        [Column("movie_description")]
        public string Description { get; set; } = string.Empty;

        [Column("movie_runtimeMins")]
        public int RuntimeMins { get; set; }

        [Column("movie_createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("movie_updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("screenings")]
        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    }
}
