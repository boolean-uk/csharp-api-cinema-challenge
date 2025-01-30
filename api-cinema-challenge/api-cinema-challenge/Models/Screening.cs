using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    public class Screening
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        [Required]
        [Column("ScreenNumber")]
        public int ScreenNumber { get; set; }
        [Required]
        [Column("Capacity")]
        public int Capacity { get; set; }
        [Required]
        [Column("StartsAt")]
        public DateTime StartsAt { get; set; }
        [Required]
        [Column("EndsAt")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [Column("CreatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
