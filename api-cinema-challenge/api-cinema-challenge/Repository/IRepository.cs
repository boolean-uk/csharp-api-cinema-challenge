using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {

        //customers
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> CreateACustomer(Customer customer);
        Task<Customer> UpdateACustomer(Customer customer);
        Task<Customer> DeleteACustomer(int customerId);
        Task<Customer> GetCustomerById(int id);

        //screenings
        Task<IEnumerable<Screening>> GetAllCScreenings(int movieId);
        Task<Screening> CreateScreening(Screening screening);
        

        //movies
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> CreateAMovie(Movie movie);
        Task<Movie> UpdateAMovie(Movie movie);
        Task<Movie> GetMovieById(int id);
        Task<Movie> DeleteAMovie(int movieId);
    }
}
