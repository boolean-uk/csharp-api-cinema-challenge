using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        // Customer
        Task<Customer> AddCustomer(Customer customer);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomerId(int id);
        Task<Customer> UpdateCustomer(int id, Customer customer);
        Task<Customer> DeleteCustomer(int id);

        // Movie
        Task<Movie> AddMovie(Movie movie);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieId(int id);
        Task<Movie> UpdateMovie(int id, Movie movie);
        Task<Movie> DeleteMovie(int id);

        // Screening
        Task<Screening> AddScreening(Screening screening);
        Task<IEnumerable<Screening>> GetScreenings();
    }
}


