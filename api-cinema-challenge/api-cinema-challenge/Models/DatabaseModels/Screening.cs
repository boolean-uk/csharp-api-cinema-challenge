using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.DatabaseModels
{
    public class Screening
    {
        [Column("screening_id")]
        public int Id { get; set; }
        [Column("movie_id")]
        [ForeignKey("Movie")]
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
        public DateTime UpdateddAt { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
