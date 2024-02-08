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
        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();

    }
}
