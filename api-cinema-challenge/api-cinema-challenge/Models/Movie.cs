using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Column("movie_id")]
        public int Id { get; set; }

        [Column("movie_name")]
        public string MovieName { get; set; }

        [Column("movie_desc")]
        public string MovieDesc { get; set; }

        [Column("movie_length")]
        public int MovieLength { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
