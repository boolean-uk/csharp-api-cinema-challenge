using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        // Customers
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int id, Customer customer);
        Task<Customer> DeleteCustomer(int id);

        // Movies
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(int id, Movie movie);
        Task<Movie> DeleteMovie(int id);

        // Screenings
        Task<IEnumerable<Screening>> GetScreenings();
        Task<Screening> GetScreening(int id);
        Task<Screening> CreateScreening(Screening screening);
        Task<Screening> UpdateScreening(int id, Screening screening);
        Task<Screening> DeleteScreening(int id);

        // Tickets
        Task<IEnumerable<Ticket>> GetTickets();
        Task<Ticket> GetTicket(int id);
        Task<Ticket> CreateTicket(Ticket ticket);
        Task<Ticket> UpdateTicket(int id, Ticket ticket);
        Task<Ticket> DeleteTicket(int id);


    }
}
