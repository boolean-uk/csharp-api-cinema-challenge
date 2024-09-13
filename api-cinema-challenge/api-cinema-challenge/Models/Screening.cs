using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    public class Screening
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("MovieId")]
        [ForeignKey("Movie id")]
        public int MovieId { get; set; }

        [Column("ScreenNumber")]
        public int ScreenNumber { get; set; }

        [Column("Capacity")]
        public int Capacity { get; set; }

        [Column("StartsAt")]
        public DateTime startsAt { get; set; }


        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("Updated At")]
        public DateTime UpdatedAt { get; set; }

        public Screening( int movieId, int screenNumber, int capacity, DateTime startsAt)
        {
            MovieId = movieId;
            ScreenNumber = screenNumber;
            Capacity = capacity;
            this.startsAt = startsAt;
            CreatedAt = DateTime.Now.ToUniversalTime();
            UpdatedAt = DateTime.Now.ToUniversalTime();
        }
    }
}
