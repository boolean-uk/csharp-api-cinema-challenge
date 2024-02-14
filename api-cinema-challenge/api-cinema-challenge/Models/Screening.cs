using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    [PrimaryKey("Id")]
    public class Screening : BaseEntity
    {
        

        [Column("screen_number")]
        public int screenNumber { get; set; }

        [Column("capacity")]
        public int capacity { get; set; }

        [Column("starts_at")]
        public DateTime startsAt { get; set; }

        [Column("fk_movie_id")]
        public int MovieId { get; set; }
    }
}
