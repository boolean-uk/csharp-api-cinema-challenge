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
            return await _db.Screenings
                .Include(x => x.Movie)
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == entity.Id);
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

        public async Task<Screening> GetScreeningById(int id)
        {
            return await _db.Screenings
                .Include(x => x.Movie)
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Screening> UpdateScreening(int id, Screening entity)
        {
            var target = await _db.Screenings
                .Include(x => x.Movie)
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);

            target.UpdatedAt = DateTime.UtcNow;
            target.ScreenNumber = entity.ScreenNumber;
            target.Capacity = entity.Capacity;
            target.MovieId = entity.MovieId;
            target.StartsAt = entity.StartsAt;

            _db.Attach(target).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return await _db.Screenings
                .Include(x => x.Movie)
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Screening> DeleteScreening(int id)
        {
            var target = await _db.Screenings
                .Include(x => x.Movie)
                .Include(x => x.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (target == null)
            {
                return null;
            }

            // Removing related tickets
            foreach (Ticket t in target.Tickets)
            {
                _db.Tickets.Remove(t);
            }

            _db.Screenings.Remove(target);
            await _db.SaveChangesAsync();
            return target;
        }
    }
}
