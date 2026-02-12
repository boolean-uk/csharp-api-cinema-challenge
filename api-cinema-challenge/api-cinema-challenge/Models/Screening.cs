using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screening_table")]
    public class Screening
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("movie_id")]
        public int MovieId { get; set; }

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

    }
}
