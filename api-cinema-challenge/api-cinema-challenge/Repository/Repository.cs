using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.DataModels;

namespace api_cinema_challenge.Repository
{
    public class Repository: IRepository
    {
        private CinemaContext _databaseContext;

        public Repository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Customer> CreateCustomer(CustomerPost customer)
        {
            var newCustomer = new Customer() { Name = customer.Name, Email = customer.Email, Phone = customer.Phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            await _databaseContext.Customers.AddAsync(newCustomer);
            await _databaseContext.SaveChangesAsync();
            return newCustomer;
        }

        public async Task<Movie> CreateMovie(MoviePost movie)
        {
            var newMovie = MovieFactory.NewMovie(movie);
            await _databaseContext.Movies.AddAsync(newMovie);
            await _databaseContext.SaveChangesAsync();
            return newMovie;
        }

        public async Task<Screening> CreateScreening(int movieId, ScreeningPost screening)
        {
            var newScreening = ScreeningFactory.NewScreening(movieId, screening);
            await _databaseContext.Screenings.AddAsync(newScreening);
            await _databaseContext.SaveChangesAsync();
            return newScreening;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _databaseContext.Customers.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (customer == null) return null;
            _databaseContext.Customers.Remove(customer);
            await _databaseContext.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _databaseContext.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (movie == null) return null;
            _databaseContext.Movies.Remove(movie);
            await _databaseContext.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _databaseContext.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _databaseContext.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Screening>> GetScreenings(int movieId)
        {
            var movie = await _databaseContext.Movies.Where(m => m.Id == movieId).Include(m => m.Screenings).FirstOrDefaultAsync();
            if (movie == null) return null;
            return movie.Screenings;
        }

        public async Task<Customer> UpdateCustomer(int id, CustomerPut customerPut)
        {
            var customer = await _databaseContext.Customers.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (customer == null) return null;
            if (customerPut.Name is not null) customer.Name = customerPut.Name;
            if (customerPut.Email is not null) customer.Email = customerPut.Email;
            if (customerPut.Phone is not null) customer.Phone = customerPut.Phone;
            customer.UpdatedAt = DateTime.UtcNow;
            await _databaseContext.SaveChangesAsync();
            return customer;
            
        }

        public async Task<Movie> UpdateMovie(int id, MoviePut moviePut)
        {
            var movie = await _databaseContext.Movies.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (movie == null) return null;
            if (movie.Title is not null) movie.Title = moviePut.Title;
            if (movie.Rating is not null) movie.Rating = moviePut.Rating;
            if (movie.Description is not null) movie.Description = moviePut.Description;
            if (movie.RuntimeMins != 0 && movie.RuntimeMins != moviePut.RuntimeMins) movie.RuntimeMins = moviePut.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;
            await _databaseContext.SaveChangesAsync();
            return movie;
        }
    }
}
