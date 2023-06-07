using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface iRepositoryCinema
    {
        IEnumerable<Customer> GetCustomers();
        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        Customer DeleteCustomer(int id);

        IEnumerable<Movie> GetMovies();
        Movie AddMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        Movie DeleteMovie(int id);

        IEnumerable<Screening> GetScreenings(int id);
        Screening AddScreening(Screening screening);
    }
}
