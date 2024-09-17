using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screening")]
    public class Screening
    {
        [Key]
        [Column("ScreeningId")]
        public int Id { get; set; }

        [Column("Capacity")]
        public int Capacity { get; set; }

        [Column("ScreenNumber")]
        public int ScreenNumber { get; set; }

        [Column("StartsAt")]
        public DateTime StartsAt { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }


        [ForeignKey("Movie")]
        [Column("MovieId")]
        public int MovieId { get; set; }
        
        public Movie movie { get; set; }

    }
}
