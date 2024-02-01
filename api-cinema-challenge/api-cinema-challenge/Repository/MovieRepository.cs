using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private CinemaContext _cinemaContext;
        public MovieRepository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<Movie> CreateMovie(string title, string rating, string description, int runtimeMins)
        {
            Movie movie = new Movie();
            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.RuntimeMins = runtimeMins;
            movie.CreatedAt = DateTime.Now.ToUniversalTime();
            movie.UpdatedAt = DateTime.Now.ToUniversalTime();
            await _cinemaContext.Movies.AddAsync(movie);
            _cinemaContext.SaveChanges();
            return movie;
        }

        public async Task<Movie> DeleteMovie(Movie movie)
        {
            _cinemaContext.Remove(movie);
            await _cinemaContext.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie?> GetMovieByID(int id)
        {
            return await _cinemaContext.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _cinemaContext.Movies.ToListAsync();
        }

        public async Task<Movie> UpdateMovie(Movie movie, string? title, string? rating, string? description, int? runtimeMins)
        {
            if (title is not null) movie.Title = title;
            if (rating is not null) movie.Rating = rating;
            if (description is not null) movie.Description = description;
            if (runtimeMins is not null) movie.RuntimeMins = (int)runtimeMins;
            movie.UpdatedAt = DateTime.Now.ToUniversalTime();
            await _cinemaContext.SaveChangesAsync();
            return movie;
        }
    }
}
