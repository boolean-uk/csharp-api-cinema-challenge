using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        public int Id { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        
        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("movie_fk"), Column("movie_fk")]
        public int MovieId { get; set; }
    }
}
