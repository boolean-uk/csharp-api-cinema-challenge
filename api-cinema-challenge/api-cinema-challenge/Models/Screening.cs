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
        public int screenNumber { get; set; }
        [Required]
        [Column("Capacity")]
        public int capacity { get; set; }
        [Required]
        [Column("StartsAt")]
        public DateTime startsAt { get; set; }
        [Required]
        [Column("EndsAt")]
        public DateTime createdAt { get; set; }
        [Required]
        [Column("CreatedAt")]
        public DateTime updatedAt { get; set; }
    }
}
