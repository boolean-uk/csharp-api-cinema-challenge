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
        public async Task<Movie> CreateMovie(string title, string rating, string description, int runtimeMins, List<ScreeningPayload>? screenings)
        {
            Movie movie = new Movie();
            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.RuntimeMins = runtimeMins;
            movie.CreatedAt = DateTime.Now.ToUniversalTime();
            movie.UpdatedAt = DateTime.Now.ToUniversalTime();
            movie.screenings = new List<Screening>();
            await _cinemaContext.Movies.AddAsync(movie);
            _cinemaContext.SaveChanges();
            if (screenings is not null) 
                //Happens at the same time as creating the movie, so foreign key of the screening can't refer to the movie, cause the movie doesn't exist yet
            {
                foreach (ScreeningPayload screening in screenings)
                {
                    Screening result = await CreateScreening(movie.Id, screening.screenNumber, screening.capacity, screening.startsAt);
                    movie.screenings.Add(result);
                }
            }
            _cinemaContext.SaveChanges();
            return movie;
        }

        public async Task<Movie> DeleteMovie(Movie movie)
        {
            _cinemaContext.Remove(movie);
            ICollection<Screening> screenings = await GetScreenings(movie.Id);
            foreach (Screening screening in screenings)
            {
                _cinemaContext.Remove(screening);
            }
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

        public async Task<Screening> CreateScreening(int movieID, int screenNumber, int capacity, DateTime startsAt)
        {
            Screening screening = new Screening();
            screening.ScreenNumber = screenNumber;
            screening.MovieId = movieID;
            screening.Capacity = capacity;
            screening.UpdatedAt = DateTime.Now.ToUniversalTime();
            screening.CreatedAt = DateTime.Now.ToUniversalTime();
            screening.StartsAt = startsAt;
            await _cinemaContext.Screenings.AddAsync(screening);
            _cinemaContext.SaveChanges();
            return screening;
        }

        public async Task<ICollection<Screening>> GetScreenings(int movieId)
        {
            return await _cinemaContext.Screenings.Where(s => s.MovieId == movieId).ToListAsync();
        }
        public async Task<ICollection<Screening>> GetAllScreenings()
        {
            return await _cinemaContext.Screenings.Include(x => x.Movie).ToListAsync();
        }

        public async Task<Screening?> GetScreeningByID(int screeningId)
        {
            return await _cinemaContext.Screenings.FirstOrDefaultAsync(x => x.Id == screeningId);
        }
    }
}
