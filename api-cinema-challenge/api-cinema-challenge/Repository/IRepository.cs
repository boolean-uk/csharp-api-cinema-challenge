using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screen;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        // Get all
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Screen> GetScreens();
        IEnumerable<Movie> GetMovies();

        // Get one
        Customer GetCustomer(int id);
        Movie GetMovie(int id);
        
        // Add one
        bool AddCustomer (Customer customer);
        bool AddScreen(Screen screen);
        bool AddMovie(Movie movie);
        
        // Update one
        bool UpdateCustomer (int id, Customer customer);
        bool UpdateMovie (int id, Movie movie);
        
        // Delete one
        bool DeleteCustomer (int id);
        bool DeleteMovie (int id);
        
    }
}
