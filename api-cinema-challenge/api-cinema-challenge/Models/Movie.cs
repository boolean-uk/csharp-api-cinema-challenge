using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Column("movie_id")]
        public int Id { get; set; }

        [Column("movie_name")]
        public string Name { get; set; }

        [Column("movie_desc")]
        public string Desc { get; set; }

        [Column("movie_length")]
        public int Length { get; set; }

        [Column("created_at")]
        public DateTime Created_At { get; set; }

        [Column("updated_at")]
        public DateTime Updated_At { get; set; }
    }
}
