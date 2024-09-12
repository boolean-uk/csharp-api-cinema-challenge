using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [Column("screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("startsAt")]
        public DateTime StartsAt { get; set; }

        [ForeignKey("movieFk")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
