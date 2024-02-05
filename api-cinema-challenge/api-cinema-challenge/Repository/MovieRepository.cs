using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Posts;
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

        public async Task<Movie> AddMovie(Movie movie)
        {
            await _db.Movies.AddAsync(movie);
            _db.SaveChanges();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.Include(movie => movie.Screenings).ToListAsync();
        }

        public async Task<Movie?> UpdateMovie(int id, MoviePut movie)
        {
            var foundMovie = await _db.Movies.FirstOrDefaultAsync(movie => movie.Id == id);
            if (foundMovie == null)
            {
                return null;
            }

            if (movie.Title != null) { foundMovie.Title = movie.Title; }
            if (movie.Rating != null) { foundMovie.Rating = movie.Rating; }
            if (movie.Description != null) { foundMovie.Description = movie.Description; }
            if (movie.Runtime != null) { foundMovie.Runtime = (int)movie.Runtime; }
            foundMovie.UpdatedAt = DateTime.UtcNow;

            _db.SaveChanges();
            return foundMovie;
        }

        public async Task<Movie?> DeleteMovie(int id)
        {
            var foundMovie = await _db.Movies.FirstOrDefaultAsync(movie => movie.Id == id);
            if (foundMovie == null)
            {
                return null;
            }

            _db.Remove(foundMovie);
            _db.SaveChanges();
            return foundMovie;
        }
    }
}
