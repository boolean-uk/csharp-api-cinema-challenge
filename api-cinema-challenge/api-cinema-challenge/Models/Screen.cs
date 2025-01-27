using api_cinema_challenge.Enum;

namespace api_cinema_challenge.Models
{
    public class Screen
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public List<Seat> Seats { get; set; } = [];
        public List<Screening> Screenings { get; set; } = [];
    }
}
