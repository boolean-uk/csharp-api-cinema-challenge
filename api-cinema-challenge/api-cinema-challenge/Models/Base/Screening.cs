namespace api_cinema_challenge.Models.Base
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

        public Movie Movie { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
    }
}
