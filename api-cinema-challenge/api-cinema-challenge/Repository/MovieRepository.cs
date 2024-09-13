using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _db;

        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Movie> CreateMovie(Movie entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return await _db.Movies
                .Include(x => x.Screenings)
                .FirstOrDefaultAsync(x => x.Id == entity.Id);
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _db.Movies
                .Include(x => x.Screenings)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies
                .Include(x => x.Screenings)
                .ToListAsync();
        }

        public async Task<Movie> UpdateMovie(int id, Movie entity)
        {
            var target = await _db.Movies
                .Include(x => x.Screenings)
                .FirstOrDefaultAsync(x => x.Id == id);

            target.UpdatedAt = DateTime.UtcNow;
            target.Title = entity.Title;
            target.Rating = entity.Rating;
            target.Description = entity.Description;

            _db.Attach(target).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return target;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movieTarget = await _db.Movies
                .Include(x => x.Screenings)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (movieTarget == null)
            {
                return null;
            }

            // Removing movie screenings and related tickets
            foreach (Screening s in movieTarget.Screenings)
            {
                foreach (Ticket t in s.Tickets)
                {
                    _db.Tickets.Remove(t);
                }
                _db.Screenings.Remove(s);
            }

            _db.Movies.Remove(movieTarget);
            await _db.SaveChangesAsync();
            return movieTarget;
        }
    }
}
