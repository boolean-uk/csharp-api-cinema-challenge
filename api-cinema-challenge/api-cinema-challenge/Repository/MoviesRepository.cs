using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private CinemaContext _db;
        public MoviesRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Movies?> CreateMovie(string title, string rating, string description, int runtime)
        {
            //Create movie to return
            Movies movie = new Movies();
            //Populate the movie with payload data
            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.RuntimeMins = runtime;
            //add movie to database and save it + return
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return movie;
        }
        public async Task<Movies?> GetMovie(int id)
        {
            return await _db.Movies.FindAsync(id);
        }
        public async Task<IEnumerable<Movies>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }
        public async Task<Movies?> UpdateMovie(int id, string? Title, string? Rating, string? Description, int? Runtime)
        {
            //Get movie to be updated
            var movie = await GetMovie(id);
            //Add updated data to movie
            movie.Title = Title;
            movie.Rating = Rating;
            movie.Description = Description;
            movie.RuntimeMins = (int)Runtime;
            movie.UpdatedAt = DateTime.UtcNow;
            //Return movie now with updated data and save changes
            _db.SaveChanges();
            return movie;
        }
        public async Task<Movies?> DeleteMovie(int id)
        {
            var movie = await GetMovie(id);
            _db.Movies.Remove(movie);
            _db.SaveChanges();
            return movie;
        }
    }
}
