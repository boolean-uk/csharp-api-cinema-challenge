using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models.Interfaces;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screenings : BaseCustomModel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("movie_id")]
        public int MovieId { get; set; }

        [Column("screen_number")]
        public int ScreenNumber { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
