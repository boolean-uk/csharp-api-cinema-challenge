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
        [Column("imdb_rating")]
        public string IMDBRating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtime_min")]
        public int RuntimeMin { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();

    }

    public class MoviePost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IMDBRating { get; set; }
        public int RuntimeMin { get; set; }
    }
}
