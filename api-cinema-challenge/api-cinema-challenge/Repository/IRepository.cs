using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Customer>> GetCustomersWithScreening();

        Task<IEnumerable<Customer>> GetCustomersWithoutScreening();

        Task<Customer> GetCustomerById(int id);

        Task<Customer> CreateCustomer(Customer entity);

        Task<Customer> UpdateCustomer(Customer entity);

        Task<Customer> DeleteCustomer(int id);

        Task<IEnumerable<Movie>> GetMovies();

        Task<Movie> GetMovieById(int id);

        Task<Movie> CreateMovie(Movie entity);

        Task<Movie> UpdateMovie(Movie entity);

        Task<Movie> DeleteMovie(int id);

    }
}
