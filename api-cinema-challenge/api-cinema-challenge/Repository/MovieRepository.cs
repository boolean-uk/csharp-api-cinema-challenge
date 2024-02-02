using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository {

    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _db;

        public MovieRepository(CinemaContext db) {
            _db = db;
        }

        public async Task<Movie> CreateMovie(string title, string rating, string description, string runtimeMins)
        {
            Movie movie = new Movie()
            {
                Title = title,
                Rating = rating,
                Description = description,
                RuntimeMins = runtimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _db.Movies
                .Where(movie => movie.Id == id)
                .FirstOrDefaultAsync();
            if(movie == null)
                return null;
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie?> GetMovie(int id)
        {
            var movie = await _db.Movies
                            .Include(movie => movie.Screenings)
                            .Where(movie => movie.Id == id)
                            .FirstOrDefaultAsync();
            if(movie == null)
                return null;
            return movie;
        }

        public Task<Movie> UpdateMovie(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}