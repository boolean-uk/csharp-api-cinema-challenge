using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        // Customers
        Task<Customer> CreateCustomer(Customer entity);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int customerId);
        Task<Customer> UpdateACustomer(int customerId);
        Task<Customer> DeleteACustomer(int customerId);

        // Screenings
        Task<IEnumerable<Screening>> GetAllScreenings(int movieId);
        Task<Screening> CreateScreening(Screening entity);
        Task<Screening> GetScreeningById(int screeningId);

        // Movies
        Task<Movie> CreateMovie(Movie entity);
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> GetMovieById(int movieId);
        Task<Movie> UpdateAMovie(int movieId);
        Task<Movie> DeleteAMovie(int movieId);
    }
}
