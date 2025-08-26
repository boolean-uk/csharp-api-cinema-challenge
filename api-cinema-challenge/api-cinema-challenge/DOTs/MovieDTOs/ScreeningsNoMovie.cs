using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.MovieDTOs
{
    public class ScreeningsNoMovie
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public IEnumerable<TicketNoScreening> Tickets { get; set; } = new List<TicketNoScreening>();

        public ScreeningsNoMovie(Screening screening)
        {
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            Tickets = screening.Tickets.Select(t => new TicketNoScreening(t));
        }
    }
}
