using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screens")]
    public class Screen
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Screening> Screenings { get; set; } = new List<Screening>();
    }
}