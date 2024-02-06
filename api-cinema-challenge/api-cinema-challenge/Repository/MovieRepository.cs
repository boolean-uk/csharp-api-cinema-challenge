using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CinemaContext _context;

        public MovieRepository(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovie(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<Movie> CreateMovie(string title , string rating , string description , int runtimeMins)
        {
            var movie = new Movie
            {
                Title = title ,
                Rating = rating ,
                Description = description ,
                RuntimeMins = runtimeMins
            };

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        public async Task<Movie> UpdateMovie(int id , string title , string rating , string description , int runtimeMins)
        {
            var movie = await _context.Movies.FindAsync(id);
            if(movie == null)
            {
                throw new ArgumentNullException(nameof(movie) , "Movie cannot be null.");
            }

            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.RuntimeMins = runtimeMins;

            await _context.SaveChangesAsync();

            return movie;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if(movie == null)
            {
                return null;
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return movie;
        }
    }
}
