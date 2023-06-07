using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ICinemaRepository
    {
        Customer AddCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        Customer UpdateCustomer(Customer customer);
        Customer DeleteCustomer(int id);

        Movie AddMovie(Movie movie);
        IEnumerable<Movie> GetMovies();
        Movie UpdateMovie(Movie movie);
        Movie DeleteMovie(int id);

        Screening AddScreening(Screening screening, int movieId);
        IEnumerable<Screening> GetScreenings();
        Screening UpdateScreening(Screening screening);
        Screening DeleteScreening(int id);

        Ticket AddTicket(Ticket ticket, int screeningId);
        IEnumerable<Ticket> GetTickets();

    }
}
