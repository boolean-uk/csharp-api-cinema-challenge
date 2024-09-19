using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        private readonly CinemaContext _db;
        public ScreeningRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screening> CreateScreening(Screening screening)
        {
            await _db.Screenings.AddAsync(screening);
            await _db.SaveChangesAsync();
            return await _db.Screenings
                .Include(s => s.Tickets)
                .ThenInclude(s => s.Customer)
                .Include(s => s.Movie)
                .FirstOrDefaultAsync(s => s.Id == screening.Id);
        }

        public async Task DeleteScreening(int id)
        {
            Screening target = await _db.Screenings.FindAsync(id);
            _db.Screenings.Remove(target);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Screening>> GetAllScreenings()
        {
            return await _db.Screenings
               .Include(s => s.Tickets)
               .ThenInclude(s => s.Customer)
               .Include(s => s.Movie)
               .ToListAsync();
        }

        public async Task<Screening> GetScreeningById(int id)
        {
            return await _db.Screenings
               .Include(s => s.Tickets)
               .ThenInclude(s => s.Customer)
               .Include(s => s.Movie)
               .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Screening>> GetScreeningsByMovieId(int id)
        {
            Movie target = await _db.Movies
                .Include(m => m.Screenings)
                .ThenInclude(m => m.Tickets)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (target == null)
            { return null; }

            return target.Screenings;
        }

        public async Task<Screening> UpdateScreening(int id, Screening newValues)
        {
            Screening target = await _db.Screenings
               .Include(s => s.Tickets)
               .ThenInclude(s => s.Customer)
               .Include(s => s.Movie)
               .FirstOrDefaultAsync(s => s.Id == id);

            target.UpdatedAt = DateTime.UtcNow;
            target.ScreenNumber = newValues.ScreenNumber;
            target.Capacity = newValues.Capacity;
            target.MovieId = newValues.MovieId;
            target.StartsAt = newValues.StartsAt;

            _db.Attach(target).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return target;
        }
    }
}
