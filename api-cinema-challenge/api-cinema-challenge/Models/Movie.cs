 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [Column("MovieId")]
        public int Id { get; set; }

        [Required]
        [Column("MovieTitle")]
        public required string Title { get; set; }

        [Required]
        [Column("Rating")]
        public required string Rating { get; set; }

        [Required]
        [Column("MovieDescription")]
        public required string Description { get; set; }

        [Required]
        [Column("RuntimeMinutes")]
        public int RuntimeMins { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property for related screenings
        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    }
}
