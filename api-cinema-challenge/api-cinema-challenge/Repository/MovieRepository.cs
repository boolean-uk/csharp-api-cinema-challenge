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
            return entity;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movieTarget = await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (movieTarget == null)
            {
                return null;
            }

            var screeningTarget = await _db.Screenings.FirstOrDefaultAsync(x => x.MovieId == id);
            if (screeningTarget != null)
            {
                screeningTarget.MovieId = 0;
            }

            _db.Movies.Remove(movieTarget);
            await _db.SaveChangesAsync();
            return movieTarget;
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

            return target;
        }
    }
}
