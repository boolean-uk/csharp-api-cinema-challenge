namespace api_cinema_challenge.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime StartingAt { get; set; }
        public DateTime EndingAt { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }

        public List<Ticket> Tickets { get; set; } = [];
    }
}
