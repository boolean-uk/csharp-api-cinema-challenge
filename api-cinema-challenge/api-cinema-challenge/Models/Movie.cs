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

        [Column("run_time")]
        public int Runtime { get; set; }

        [Column("created_time")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("utdated_time")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Screening> Screenings { get; set;} = new List<Screening>();


    }
}
