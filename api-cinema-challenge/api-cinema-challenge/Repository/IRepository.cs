using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(int id);
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<bool> DeleteCustomer(int id);

        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(int id);
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie movie);
        Task<bool> DeleteMovie(int id);

        Task<IEnumerable<Screening>> GetScreenings(int id);
        Task<Screening> AddScreening(Screening screening);
        Task<Screening> AddScreeningMovie(Screening screening);

        Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningId);
        Task<IEnumerable<Ticket>> GetTicketsCustomer(int customerId);
        Task<Ticket> AddTicket(Ticket ticket);







    }
}
