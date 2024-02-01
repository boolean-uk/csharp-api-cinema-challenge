using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer?> GetCustomer(int customerId);
        Task<Customer?> UpdateCustomer(int customerId, Customer customer);
        Task<Customer?> DeleteCustomer(int customerId);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie?> GetMovie(int movieId);
        Task<Movie?> UpdateMovie(int movieId, Movie movie);
        Task<Movie?> DeleteMovie(int movieId);
        Task<Screening?> CreateScreening(Movie movie, Screening screening);
        Task<Screening?> GetScreening(int screeningId);
        Task<IEnumerable<Screening>?> GetScreeningsForMovie(int movieId);
    }
}
