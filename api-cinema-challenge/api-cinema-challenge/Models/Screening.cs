namespace api_cinema_challenge.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation property for the related Movie
        public Movie Movie { get; set; }

        // Navigation property for related Tickets
        public ICollection<Ticket> Tickets { get; set; }
    }
}
