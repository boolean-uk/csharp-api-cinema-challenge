using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Controllers.ScreeningRepo
{
    public class ScreeningRepository : IScreeningRepository
    {

        private CinemaContext _db;

        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screening?> CreateScreening(int id, int screenNumber, int capacity, DateTime startsAt)
        {

            var movie = await _db.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }
            var screening = new Screening
            {
                ScreenNumber = screenNumber,
                Capacity = capacity,
                StartsAt = startsAt,
                MovieId = id,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            _db.Screenings.Add(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<Screening?> GetScreeningByMovieId(int id)
        {
            return await _db.Screenings.FindAsync(id);
        }
    }
}
