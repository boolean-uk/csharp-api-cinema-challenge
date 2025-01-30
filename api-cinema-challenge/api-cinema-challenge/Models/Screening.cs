using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Movie")]
        [Column("movie_id")]
        public int MovieId { get; set; }

        [Required]
        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Required]
        [Column("capacity")]
        public int Capacity { get; set; }

        [Required]
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }

        [Column("created_at")] 
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public Movie Movie { get; set; } // Navigation property for Movie

        [JsonIgnore]
        public List<Ticket> Tickets { get; set; } // One-to-Many with Tickets
    }
}
