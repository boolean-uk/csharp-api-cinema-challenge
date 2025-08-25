using api_cinema_challenge.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening : DbEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
