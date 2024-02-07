using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.PureModels
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("title")]
        [MaxLength(255)]
        public string Title { get; set; }

        [Column("rating")]
        [MaxLength(15)]
        public string Rating { get; set; }

        [Column("description")]
        [MaxLength(511)]
        public string Description { get; set; }

        [Column("runtime_minutes")]
        public int RuntimeMinutes { get; set; }

        [Column("created_at")]
        [MaxLength(31)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        [MaxLength(31)]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();

    }
}
