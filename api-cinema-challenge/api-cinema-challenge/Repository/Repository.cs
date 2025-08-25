using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _context;
        public Repository(CinemaContext context)
        {
            _context = context;
        }

        // Customer
        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
        public async Task<Customer> GetCustomerId(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }
        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            var target = await _context.Customers.FindAsync(id);
            target = customer;
            await _context.SaveChangesAsync();
            return target;
        }
        public async Task<Customer> DeleteCustomer(int id)
        {
            var target = await _context.Customers.FindAsync(id);
            if (target == null) return null;
            _context.Customers.Remove(target);
            await _context.SaveChangesAsync();
            return target; 
        }

        // Movie
        public async Task<Movie> AddMovie(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieId(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<Movie> UpdateMovie(int id, Movie movie)
        {
            var target = await _context.Movies.FindAsync(id);
            target = movie;
            await _context.SaveChangesAsync();
            return target;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var target = await _context.Movies.FindAsync(id);
            if (target == null) return null;
            _context.Movies.Remove(target);
            await _context.SaveChangesAsync();
            return target;
        }

        public async Task<Screening> AddScreening(Screening screening)
        {
            await _context.Screenings.AddAsync(screening);
            await _context.SaveChangesAsync();
            return screening;
        }

        public async Task<IEnumerable<Screening>> GetScreenings()
        {
            return await _context.Screenings.ToListAsync(); 
        }
    }
}
