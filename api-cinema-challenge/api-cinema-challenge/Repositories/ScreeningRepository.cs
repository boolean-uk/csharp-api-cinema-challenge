using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        public Screening CreateScreening(int movieId, ScreeningPost s)
        {
            using (var db = new CinemaContext())
            {
                // get movie with this movieId
                Movie movie = db.Movies.SingleOrDefault(m => m.id == movieId);

                DateTime date = DateTime.UtcNow;
                Screening screening = new Screening()
                {
                    screenNumber = s.screenNumber,
                    capacity = s.capacity,
                    startsAt = s.startsAt,
                    createdAt = date,
                    updatedAt = date,
                    movieId = movieId,
                    movie = movie
                };

                db.Screenings.Add(screening);
                db.SaveChanges();
                return screening;
            };
            return null;
        }

        public IEnumerable<Screening> GetScreenings(int movieId)
        {
            using (var db = new CinemaContext())
            {
                return db.Screenings.ToList().FindAll(s => s.movieId == movieId);
            }
            return null;
        }
    }
}
