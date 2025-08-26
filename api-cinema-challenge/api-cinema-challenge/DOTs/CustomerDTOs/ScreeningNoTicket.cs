using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.CustomerDTOs
{
    public class ScreeningNoTicket
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public MovieNoScreenings Movie { get; set; }

        public ScreeningNoTicket(Screening screening)
        {
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            Movie = new MovieNoScreenings(screening.Movie);
        }
    }
}
