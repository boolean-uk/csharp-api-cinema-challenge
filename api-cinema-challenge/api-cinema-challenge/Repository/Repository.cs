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
        //Connect to DB
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
        public async Task<User> CreateUser(string name, string email, string phoneNumber)
        {
            User user = new User();
            user.Name = name;
            user.Email = email;
            user.PhoneNumber = phoneNumber;
            user.CreatedAt = DateTime.UtcNow;
            user.UpdatedAt = DateTime.UtcNow;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;

        }

        //update user
        public async Task<User> UpdateUser(int id, UpdateUserPayload updateData)
        {
            
            string name = (string)updateData.name;
            string email = (string)updateData.email;
            string phoneNumber = (string)updateData.phoneNumber;

            if (name == null ||
                email == null ||
                phoneNumber == null)
            {
                return null;
            }

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
            Movie movie = new Movie();
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
        public async Task<Movie> UpdateMovie(int id, UpdateMoviePayload UpdateData) 
        {

            string title = (string)UpdateData.title;
            string rating = (string)UpdateData.rating;
            string description = (string)UpdateData.description;
            int runtime = (int)UpdateData.runtime;

            if (title == null ||
                rating == null ||
                description == null ||
                runtime == null)
            {
                return null;
            }

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

            Screening screening = new Screening();
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
