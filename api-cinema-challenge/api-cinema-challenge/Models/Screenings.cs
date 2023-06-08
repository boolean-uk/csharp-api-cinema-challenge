using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screenings
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }

        [ForeignKey("Movies")]
        public int MoviesId { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
