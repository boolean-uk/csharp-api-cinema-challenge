using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        [Key]
        [Column("screening_id")]
        public int Id { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("start_at", TypeName = "Date")]
        public DateTime StartAt { get; set; }

        [Column("created_at", TypeName = "Date")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "Date")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("movie_id")]
        public int MovieId { get; set; }    
        public Movie Movie { get; set; }



    }
}
