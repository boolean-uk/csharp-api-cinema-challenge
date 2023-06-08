using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICinemaRepository
    {
        Customer AddCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        Customer DeleteCustomer(int id);
        Customer UpdateCustomer(Customer customer);

        Movie AddMovie(Movie movie);
        IEnumerable<Movie> GetMovies();
        Movie DeleteMovie(int id);
        Movie UpdateMovie(Movie movie);

        Screening AddScreening(Screening screening, int movieId);
        IEnumerable<Screening> GetScreenings();
        Screening DeleteScreening(int id);
        Screening UpdateScreening(Screening screening);
       IEnumerable<Screening> GetScreeningsbyMovie(int movieid);

        IEnumerable<Ticket> GetTickets();
        Ticket AddTicket(Ticket ticket);
    }
}
