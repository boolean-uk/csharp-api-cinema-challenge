using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using System.Xml.Linq;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        
        //delete movie

        //create screening

        //set up DB connection
        private CinemaContext _context;
        public Repository(CinemaContext db) 
        {
            _context = db;
        }

        //get all users
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        //Create user
        public async Task<User> CreateUser(string name, string email, string PhoneNumber)
        {
            var users = await _context.Users.ToListAsync();
            var lastUser = users.OrderByDescending(u => u.Id).FirstOrDefault();
            int newUserId = (lastUser != null) ? lastUser.Id + 1 : 1;

            User user = new User();
            user.Id = newUserId;
            user.Name = name;
            user.Email = email;
            user.PhoneNumber = PhoneNumber;
            user.CreatedAt = DateTime.UtcNow;
            user.UpdatedAt = DateTime.UtcNow;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;

        }

        //update user
        public async Task<User> UpdateUser(int id, string name, string email, string phoneNumber)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            user.Name = name;
            user.Email = email;
            user.PhoneNumber = phoneNumber;
            user.UpdatedAt = DateTime.UtcNow;
            _context.SaveChanges();
            return user;
        }

        //delete user
        public async Task<User> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return user;
        }

        //CreateMovie
        public async Task<Movie> CreateMovie(string title, string rating, string desc, int runtime)
        {
            var movies = await _context.Movies.ToListAsync();
            var lastMovie = movies.OrderByDescending(u => u.Id).FirstOrDefault();
            int newMovieId = (lastMovie != null) ? lastMovie.Id + 1 : 1;

            Movie movie = new Movie();
            movie.Id = newMovieId;
            movie.Title = title;
            movie.Rating = rating;
            movie.RuntimeMins = runtime;
            movie.Description = desc;
            movie.CreatedAt = DateTime.UtcNow;
            movie.UpdatedAt = DateTime.UtcNow;
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        //getmovies
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        //update Movies
        public async Task<Movie> UpdateMovie(int id, string title, string rating, string description, int runtime) 
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }
            movie.Title = title;
            movie.Rating = rating;
            movie.RuntimeMins = runtime;
            movie.UpdatedAt = DateTime.UtcNow;
            _context.SaveChanges();
            return movie;
        }

        //delete movie
        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return movie;
        }

        //getscreenings
        public async Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId)
        {
            return await _context.Screens
                .Where(s => s.MovieId == movieId).ToListAsync();
        }
        
        public async Task<Screening> CreateScreening(int movieId, int screenNumber, int capacity, DateTime startsAt)
        {
            var screenings = await _context.Screens.ToListAsync();
            var lastScreening = screenings.OrderByDescending(s => s.Id).FirstOrDefault();
            int newScreeningId = (lastScreening != null) ? lastScreening.Id + 1 : 1;

            Screening screening = new Screening();
            screening.Id = newScreeningId;
            screening.MovieId = movieId;
            screening.Capacity = capacity;
            screening.ScreenNumber = screenNumber; 
            screening.StartTime = startsAt;

            screening.CreatedAt = DateTime.UtcNow;
            screening.UpdatedAt = DateTime.UtcNow;
            _context.Screens.Add(screening);
            _context.SaveChanges();
            return screening;
        }
        
    }
}
