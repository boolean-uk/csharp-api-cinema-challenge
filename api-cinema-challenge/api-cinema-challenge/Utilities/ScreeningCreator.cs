using api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using System.Security.Cryptography.X509Certificates;

namespace api_cinema_challenge.Utilities
{
    public class ScreeningCreator
    {
        public ScreeningCreator(int movieId, Auditorium auditoriumWithSeats, int capacity, DateTime startsAt)
        {
            MovieId = movieId;
            Auditorium = auditoriumWithSeats;
            Capacity = capacity;
            StartsAt = DateTime.SpecifyKind(StartsAt, DateTimeKind.Utc);
        }

        public Screening GetScreening()
        {
            Screening screening = new Screening();
            screening.MovieId = MovieId;
            screening.StartsAt = StartsAt;
            return screening;
        }

        public List<ScreeningSeat> GetScreeningSeats(int screeningId)
        {
            List<Seat> auditoriumSeats = Auditorium.Seats.ToList();
            int numSeatsForScreening = int.Min(Auditorium.Seats.Count, Capacity);
            return auditoriumSeats.Take(numSeatsForScreening).Select(s => new ScreeningSeat() { SeatId = s.Id, ScreeningId = screeningId, TicketId = null}).ToList();
        }

        public int MovieId { get; set; }
        Auditorium Auditorium { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
