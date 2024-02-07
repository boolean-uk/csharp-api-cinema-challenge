using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("title")]
        [Required]
        public string Title { get; set; }

        [Column("rating")]
        [Required]
        public string Rating { get; set; }

        [Column("description")]
        [Required]
        public string Description { get; set; }

        [Column("runttime_mins")]
        [Required]
        public int RuntimeMins { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("available")]
        [Required]
        public bool Available { get; set; } = true;

        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();

    }
}
