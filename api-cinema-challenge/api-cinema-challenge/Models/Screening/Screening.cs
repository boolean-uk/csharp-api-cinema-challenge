using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Screening
{
    [Table("SCREENING")]
    public class Screening
    {
        [Key]
        [Required]
        [Column("ID")]
        public int Id { get; set; }
        [Column("SCREENNUMBER")]
        public int ScreenNumber { get; set; }
        [Column("CAPACITY")]
        public int Capacity { get; set; }
        [Column("STARTSAT")]
        public DateTime StartsAt { get; set; }
        [Column("CREATEDAT")]
        public DateTime createdAt { get; set; }
        [Column("UPDATEDAT")]
        public DateTime updatedAt { get; set; }
    }
}
