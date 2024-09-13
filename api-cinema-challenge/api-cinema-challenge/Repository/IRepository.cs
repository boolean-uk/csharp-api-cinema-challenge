using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> CreateACustomer(Customer entity);
        Task<Customer> UpdateACustomer(int customerId);
        Task<Customer> DeleteACustomer(int customerId);


        Task<IEnumerable<Screening>> GetAllCScreenings(int movieId);
        Task<Screening> CreateScreening(int movieId);

        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> CreateAMovie(Movie entity);
        Task<Movie> UpdateAMovie(int movieId);
        Task<Movie> DeleteAMovie(int movieId);
    }
}
