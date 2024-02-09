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
        public async Task<Movie> CreateMovie(Movie request)
        {
            Movie newMovie = new Movie()
            {
                
                Title = request.Title,
                Description = request.Description,
                Rating = request.Rating,
                RuntimeMins = request.RuntimeMins,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime(),
                Id = request.Id
                // Screenings = request.Screenings
            };
            if (request.Screenings != null)
            {
                newMovie.Screenings = request.Screenings;
            }
            _db.Movies.Add(newMovie);
            await _db.SaveChangesAsync();
            return newMovie;
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _db.Movies.Where(m => m.Id == id).FirstOrDefaultAsync()
                ?? throw new ArgumentException($"Movie with id: {id} does not exist");
        }

        public async Task<ICollection<Movie>> GetMovies()
        {
            return await _db.Movies.ToArrayAsync()
                ?? throw new NullReferenceException("No movies!!!!! >:C");
        }

        public async Task<Movie> UpdateMovie(Movie request)
        {
          
            _db.Entry(request).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return request;
        }

        public async Task<Movie> DeleteMovie(Movie movie)
        {
            var deleteMovie = await GetMovieById(movie.Id);

            _db.Movies.Remove(deleteMovie);

            // Remove screening with that movieID
            _db.screenings.RemoveRange(_db.screenings.Where(s => s.MovieId == movie.Id));
            await _db.SaveChangesAsync();
            return movie;
        }
    }
}
