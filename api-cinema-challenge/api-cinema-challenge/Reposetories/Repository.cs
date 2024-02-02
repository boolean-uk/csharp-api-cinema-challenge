using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace api_cinema_challenge.Reposetories
{
    public class Repository : IRepository
    {
        private CinemaContext _cinemaContext;
        public Repository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<Customer> CreateCustomer(string name, string email, string phoneNumber)
        {
            Customer customer = new Customer();
            customer.name = name;
            customer.email = email;
            customer.phone = phoneNumber;
            customer.createdAt = DateTime.Now.ToUniversalTime();
            customer.updatedAt = DateTime.Now.ToUniversalTime();
            _cinemaContext.Customers.Add(customer);
            _cinemaContext.SaveChanges();
            return customer;
        }


        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            var customers = await _cinemaContext.Customers.ToListAsync();
            _cinemaContext.SaveChanges();

            return customers;
        }

        public async Task<Customer?> UpdateCustomer(int id, string name, string email, string phoneNumber)
        {
            var customer = await _cinemaContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }
            customer.name = name;
            customer.email = email;
            customer.phone = phoneNumber;
            customer.updatedAt = DateTime.Now.ToUniversalTime();

            
            _cinemaContext.SaveChanges();
            return customer;

        }
        public async Task<Customer?> DeleteCustomer(int id)
        {
            var customer = await _cinemaContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }

            var result = customer;

            _cinemaContext.Customers.Remove(customer);

            _cinemaContext.SaveChanges();

            return result;

        }

        public async Task<Movie> CreateMovie(string title, string rating, string description, int runtimeMins)
        {
            Movie movie = new Movie();
            movie.title = title;
            movie.rating = rating;
            movie.Description = description;
            movie.runtimeMins = runtimeMins;
            movie.createdAt = DateTime.Now.ToUniversalTime();
            movie.updatedAt = DateTime.Now.ToUniversalTime();
            _cinemaContext.Movies.Add(movie);
            _cinemaContext.SaveChanges();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = await _cinemaContext.Movies.ToListAsync();
            _cinemaContext.SaveChanges();

            return movies;
        }

        public async Task<Movie?> UpdateMovie(int id, string title, string rating, string description, int runtimeMins)
        {
            var movie = await _cinemaContext.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }
            movie.title = title;
            movie.rating = rating;
            movie.Description = description;
            movie.runtimeMins = runtimeMins;
            movie.updatedAt = DateTime.Now.ToUniversalTime();

            _cinemaContext.SaveChanges();
            return movie;
        }

        public async Task<Movie?> DeleteMovie(int id)
        {
            var movie = await _cinemaContext.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }

            var result = movie;

            _cinemaContext.Movies.Remove(movie);

            _cinemaContext.SaveChanges();

            return result;
        }

        public async Task<Screening> CreateScreening(int screenNumber, int capasity, DateTime startsAt, int movieID)
        {
            var movie = await _cinemaContext.Movies.FindAsync(movieID);
            Screening screening = new Screening();
            screening.screenNumber = screenNumber;
            screening.capacity = capasity;
            screening.startsAt = startsAt.ToUniversalTime();
            screening.movieId = movieID;
            screening.movie = movie;
            screening.createdAt = DateTime.Now.ToUniversalTime();
            screening.updatedAt = DateTime.Now.ToUniversalTime();
            _cinemaContext.Screenings.Add(screening);
            _cinemaContext.SaveChanges();
            return screening;
        }

        public async Task<IEnumerable<Screening>> GetScreenings()
        {
            var screenings = await _cinemaContext.Screenings.Include(s => s.movie).ToListAsync();
            _cinemaContext.SaveChanges();

            return screenings;

        }

        
    }
}
