using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    public class Screen
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<Screening> Screenings { get; set; }
    }
}
