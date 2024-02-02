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

        public async Task<Screening?> Add(int movieId, int screenId, DateTime startsAt, float price)
        {
            var screen = await _db.Screens.FirstOrDefaultAsync(s => s.Id == screenId);
            if (screen == null)
            {
                throw new InvalidOperationException($"Screen id {screenId} was not found");
            }
            var movie = await _db.Movies.FirstOrDefaultAsync(m => m.Id == movieId);
            if (movie == null)
            {
                throw new InvalidOperationException($"Movie id {movieId} was not found");
            }
            if (movie.Available == false) { throw new InvalidOperationException("The movie is not available for screenings"); }


            bool isScreeningOngoing = await _db.Screenings
                .AnyAsync(s => s.ScreenId == screenId &&
                startsAt >= s.StartsAt && startsAt < s.StartsAt.AddMinutes(s.Movie.RuntimeMins));

            if (isScreeningOngoing) { throw new InvalidOperationException($"A screening is already ongoing at that time"); }


            var newScreening = await _db.Screenings.AddAsync(new Screening { MovieId = movieId, ScreenId = screenId, StartsAt = startsAt, Price = price, RemaningCapacity = screen.Capacity });
            await _db.SaveChangesAsync();
            return newScreening.Entity;
        }

        public async Task<List<Screening>> GetAll(int movieId)
        {
            return await _db.Screenings.Where(s => s.MovieId == movieId).ToListAsync();
        }
    }
}
