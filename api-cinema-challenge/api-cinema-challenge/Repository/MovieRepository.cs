using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private DataContext _db;

        public MovieRepository(DataContext db)

        {
            _db = db;

        }

        public async Task<Movie> GetMovieById(int movieId)
        {

            var movie = await _db.Movies.FirstOrDefaultAsync(x => x.Id == movieId);
            return movie;
        }


        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = await _db.Movies.ToListAsync();

            return movies;
        }

        public async Task<Movie> UpdateMovie(int movieId, Movie movie)
        {
            var movieToUpdate = await GetMovieById(movieId);

            movieToUpdate.Title = movie.Title;
            movieToUpdate.Rating = movie.Rating;
            movieToUpdate.Description = movie.Description;
            movieToUpdate.RunTimeMins = movie.RunTimeMins;
            movieToUpdate.UpdatedAt = DateTime.UtcNow;

            _db.Movies.Update(movieToUpdate);
            await _db.SaveChangesAsync();

            return movieToUpdate;

        }

        public async Task<Movie> CreateMovie(Movie movie)
        { 
            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();
            return movie;

        }

        public async Task<Movie> DeleteMovie(int movieId)

        {
            var movie = await GetMovieById(movieId);

            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            return movie;


        }


        public async Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId)
        {

            var screenings = await _db.Screenings.Where(s => s.MovieId == movieId).ToListAsync();

            return screenings;
        
        }


        public async Task<Screening> CreateScreenings(Screening screening)
        { 
            await _db.Screenings.AddAsync(screening);
            await _db.SaveChangesAsync();
            return screening;


        }


    }


}
