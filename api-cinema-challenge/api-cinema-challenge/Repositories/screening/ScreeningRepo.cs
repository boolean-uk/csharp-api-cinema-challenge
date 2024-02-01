using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories.customer
{
    public class ScreeningRepo : IScreeningRepository
    {
        CinemaContext _db;
        public ScreeningRepo(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Screening?> Add(int movieId, int screenNumber, int capacity, DateTime startsAt)
        {
            if (await _db.Movies.FirstOrDefaultAsync(m => m.Id == movieId) == null) { return null; }
            var newScreening = await _db.Screenings.AddAsync(new Screening { MovieId = movieId, ScreenNumber = screenNumber, Capacity = capacity, StartsAt = startsAt });
            await _db.SaveChangesAsync();
            return newScreening.Entity;
        }

        public async Task<List<Screening>> GetAll(int movieId)
        {
            return await _db.Screenings.Where(s => s.MovieId == movieId).ToListAsync();
        }
    }
}
