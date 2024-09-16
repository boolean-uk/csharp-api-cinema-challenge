using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _db;
        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();

        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            _db.Add(movie);

            if (movie.Screenings != null && movie.Screenings.Any())
            {
                foreach (var screening in movie.Screenings)
                {

                    screening.MovieId = movie.Id; 

                    _db.Screenings.Add(screening);
                }
            }

            await _db.SaveChangesAsync();

            return movie;

        }

        public async Task<Movie> UpdateMovie(int id, Movie movie)
        {
            var existingMovie = await _db.Movies.FirstOrDefaultAsync(c => c.Id == id);
            if (existingMovie == null)
                throw new KeyNotFoundException("Movie not found");

            existingMovie.UpdatedAt = DateTime.UtcNow;

            if (!string.IsNullOrEmpty(movie.Title))
                existingMovie.Title = movie.Title;

            if (!string.IsNullOrEmpty(movie.Rating))
                existingMovie.Rating = movie.Rating;

            if (!string.IsNullOrEmpty(movie.Description))
                existingMovie.Description = movie.Description;

            if (movie.RuntimeMins.HasValue)
                existingMovie.RuntimeMins = movie.RuntimeMins;

            _db.Movies.Update(existingMovie);
            await _db.SaveChangesAsync();

            return existingMovie;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var existingMovie = await _db.Movies.FirstOrDefaultAsync(c => c.Id == id);
            if (existingMovie == null)
                throw new KeyNotFoundException("Movie not found");

            if (existingMovie.Screenings != null && existingMovie.Screenings.Any())
            {
                _db.Screenings.RemoveRange(existingMovie.Screenings);
            }

            _db.Movies.Remove(existingMovie);

            await _db.SaveChangesAsync();

            return existingMovie;
        }
    }
}
