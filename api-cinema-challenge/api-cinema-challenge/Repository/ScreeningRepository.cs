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

        public async Task<Screening> CreateScreening(Screening entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Screening>> GetScreenings()
        {
            return await _db.Screenings
                .Include(x => x.Tickets)
                .Include(x => x.Movie)
                .ToListAsync();
        }

        public async Task<IEnumerable<Screening>> GetScreeningsByMovie(int id)
        {
            var movieTarget = await _db.Movies
                .Include(x => x.Screenings)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (movieTarget == null)
            {
                return Enumerable.Empty<Screening>();
            }

            return movieTarget.Screenings;
        }
    }
}
