using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class ScreeningRepository : IScreeningRepository
    {
        private CinemaContext _db;
        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Screening>> GetScreeningsByMovie(int movieId)
        {
            return await _db.Screenings
                .Where(s => s.MovieId == movieId)
                .ToListAsync();
        }

        public async Task<Screening> AddScreening(int movieId, Screening screening)
        {
            _db.Add(screening);

            await _db.SaveChangesAsync();

            return screening;
        }

    }
}
