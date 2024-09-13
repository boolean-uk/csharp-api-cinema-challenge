using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<Customer> AddCustomer(Customer customer);
        Task<Movie> AddMovie(Movie movie);
        Task<Screening> AddScreening(int MovieID, int ScreenID);
        Task<Customer> DeleteCustomer(int id);
        Task<Movie> DeleteMovie(int id);
        public Task<List<Customer>> GetAllCustomers();
        Task<List<Movie>> GetAllMovies();
        Task<List<Screening>> GetAllScreenings(int id);
        Task<Customer> UpdateCustomer(int id, Customer customer);
        Task<Movie> UpdateMovie(int id, Movie movie);
    }
}
