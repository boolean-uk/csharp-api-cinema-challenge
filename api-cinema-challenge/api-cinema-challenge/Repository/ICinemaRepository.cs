using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.Repository
{
    public interface ICinemaRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int id);

        IEnumerable<Movie> GetAllMovies();
        Movie GetMovie(int id);
        bool AddMovie(Movie movie);
        bool UpdateMovie(Movie movie);
        bool DeleteMovie(int id);

        IEnumerable<Screening> GetAllScreenings();
        bool AddScreening(Screening screening);

        IEnumerable<Ticket> GetAllTickets();
        bool BookTicket(Ticket ticket);
    }
} 
