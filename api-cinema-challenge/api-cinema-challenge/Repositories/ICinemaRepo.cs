

using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ICinemaRepo
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer CreateCustomer(Customer customer);
        Customer GetCustomerById(int id);

        Customer UpdateCustomer(Customer customer, int id);

        Customer DeleteCustomer(int id);

        IEnumerable<Movie> GetallMovies();

        Movie CreateMovie(Movie movie);
        Movie GetMovieById(int id);

        Movie UpdateMovie(Movie movie, int id);

        Movie DeleteMovie(int id);

        IEnumerable<Screening> GetallScreenings();

        Screening CreateScreening(Screening screen);
        Screening GetScreeningById(int id);

        Screening UpdateScreening(Screening screen, int id);

        Screening DeleteScreening(int id);



    }
}
