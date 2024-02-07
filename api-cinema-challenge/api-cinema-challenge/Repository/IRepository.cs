using api_cinema_challenge.DTO.Payloads;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {

        //Customer
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int customerId);
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int id, Customer customer);
        Task<bool> DeleteCustomer(int customerId);

        //Movie
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> GetMovieById(int id);
        Task<Movie> UpdateMovie(int id, Movie movie);
        Task<bool> DeleteMovie(int id);

        //Screening
        Task<List<Screening>> GetAllScreenings(int movieId);
        Task<Screening> CreateScreening(int movieId, CreateScreeningPayload payload);
        Task<Screening> AddScreening(Screening screening);

        //Ticket
        Task<List<Ticket>> GetTicketsByCustomerId(int customerId);
        Task<Screening> GetScreeningById(int screeningId);
        Task<Ticket> AddTicket(Ticket ticket);
    }
}
