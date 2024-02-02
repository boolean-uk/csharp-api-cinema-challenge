using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Data;

namespace api_cinema_challange.Models
{
    [Table("screening")]
    public class Screening
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("movie_id")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Column("screen_number")]
        public int screenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public Screening(){}
    }
}