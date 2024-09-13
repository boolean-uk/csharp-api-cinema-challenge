using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

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

        public Task<IEnumerable<Screening>> GetAllCScreenings(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAllMovies()
        {
            throw new NotImplementedException();
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
