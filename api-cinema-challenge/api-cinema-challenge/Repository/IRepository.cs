using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        public Task<IEnumerable<Customer>> GetCustomers();
        public Task<Customer> CreateCustomer(CustomerPost customer);
        public Task<Customer> UpdateCustomer(int id, CustomerPut customer);
        public Task<Customer> DeleteCustomer(int id);
        public Task<IEnumerable<Movie>> GetMovies();
        public Task<Movie> CreateMovie(MoviePost movie);
        public Task<Movie> UpdateMovie(int id, MoviePut movie);
        public Task<Movie> DeleteMovie(int id);
        public Task<IEnumerable<Screening>> GetScreenings(int movieId);
        public Task<Screening> CreateScreening(int movieId, ScreeningPost screening);
    }
}
