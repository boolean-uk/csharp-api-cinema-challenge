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

        [Column("runtime_mins")]
        public int RuntimeMins { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();

    }
}
