using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        // Customer
        Task<Customer> CreateCustomer(CustomerPost customer);
        Task<IEnumerable<CustomerDTO>> GetCustomers();
        Task<Customer> UpdateCustomer(CustomerPut customer, int id);
        Task<Customer> DeleteCustomer(int id);

        // Movie
        Task<Movie> CreateMovie(MoviePost movie);
        Task<IEnumerable<MovieDTO>> GetMovies();
        Task<Movie> UpdateMovie(MoviePut movie, int id);
        Task<Movie> DeleteMovie(int id);

        // Screening
        Task<Screening> CreateScreening(ScreeningPost screening, int movieId);
        Task<IEnumerable<ScreeningDTO>> GetScreenings(int id);
    }
}
