using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [ForeignKey("Screen")]
        [Column("screen_id")]
        [Required]
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }

        [ForeignKey("Movie")]
        [Column("movie_id")]
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column("remaning_capacity")]
        [Required]
        public int RemaningCapacity { get; set; }

        [Column("price")]
        [Required]
        public float Price { get; set; }

        [Column("starts_at")]
        [Required]
        public DateTime StartsAt { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
