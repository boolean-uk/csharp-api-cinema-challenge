using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;

        public Repository(CinemaContext db)
        {
            _db = db;
        }

        public Task<Customer> CreateACustomer(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> CreateAMovie(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task<Screening> CreateScreening(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> DeleteACustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> DeleteAMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Screening>> GetAllScreenings(int movieId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public Task<Customer> UpdateACustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateAMovie(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
