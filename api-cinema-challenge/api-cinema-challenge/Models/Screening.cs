namespace api_cinema_challenge.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }  // UTC
        public DateTime CreatedAt { get; set; } // UTC
        public DateTime UpdatedAt { get; set; } // UTC

        public int MovieId { get; set; }
        public Movie Movie { get; set; } = default!;
    }
}
