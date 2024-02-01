using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository:IRepository
    {
        private CinemaContext _databaseContext;
        public Repository(CinemaContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            await _databaseContext.Customers.AddAsync(customer);
            _databaseContext.SaveChanges();
            return customer;
        }

        public async Task<Movie> CreateMovie(Movie movie)
        {
            await _databaseContext.Movies.AddAsync(movie);
            _databaseContext.SaveChanges();
            return movie;
        }

        public async Task<Screening?> CreateScreening(Movie movie, Screening screening)
        {
            movie.Screenings.Add(screening);
            await _databaseContext.Screenings.AddAsync(screening);
            _databaseContext.SaveChanges();
            return screening;
        }

        public async Task<Customer?> DeleteCustomer(int customerId)
        {
            Customer? customer = await GetCustomer(customerId);
            if(customer == null) { return null; }
            _databaseContext.Customers.Remove(customer);
            _databaseContext.SaveChanges();
            return customer;
        }

        public async Task<Movie?> DeleteMovie(int movieId)
        {
            Movie? movie = await GetMovie(movieId);
            if(movie == null) { return null; }
            _databaseContext.Movies.Remove(movie);
            _databaseContext.SaveChanges();
            return movie;
        }

        public async Task<Customer?> GetCustomer(int customerId)
        {
            return await _databaseContext.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _databaseContext.Customers.ToListAsync();
        }

        public async Task<Movie?> GetMovie(int movieId)
        {
            return await _databaseContext.Movies.FirstOrDefaultAsync(m => m.Id == movieId); ;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _databaseContext.Movies.ToListAsync();
        }

        public async Task<Screening?> GetScreening(int screeningId)
        {
            return await _databaseContext.Screenings.FirstOrDefaultAsync(s => s.Id == screeningId); ;
        }

        public async Task<IEnumerable<Screening>?> GetScreeningsForMovie(int movieId)
        {
            return await _databaseContext.Screenings.Where(s => s.MovieId == movieId).ToListAsync(); ;
        }

        public async Task<Customer?> UpdateCustomer(int customerId, Customer customer)
        {
            Customer? customerToUpdate = await GetCustomer(customerId);
            if (customerToUpdate == null) { return null; }

            customerToUpdate.Name = customer.Name;
            customerToUpdate.Email = customer.Email;
            customerToUpdate.Phone = customer.Phone;
            customerToUpdate.UpdatedAt = DateTime.UtcNow;
            _databaseContext.SaveChanges();
            return customerToUpdate;
        }

        public async Task<Movie?> UpdateMovie(int movieId, Movie movie)
        {
            Movie? movieToUpdate = await GetMovie(movieId);
            if (movieToUpdate == null) { return null; }

            movieToUpdate.Title = movie.Title;
            movieToUpdate.Rating = movie.Rating;
            movieToUpdate.Description = movie.Description;
            movieToUpdate.RunTimeMins = movie.RunTimeMins;
            movieToUpdate.UpdatedAt = DateTime.UtcNow;
            _databaseContext.SaveChanges();
            return movieToUpdate;
        }
    }
}
