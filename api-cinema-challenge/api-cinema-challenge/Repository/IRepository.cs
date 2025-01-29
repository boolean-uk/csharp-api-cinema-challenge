using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        // Customers
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(int id);
        Task<Customer> CreateCustomer(CustomerDTO customer);
        Task<Customer> UpdateCustomer(int id, CustomerDTO customer);
        Task<Customer> DeleteCustomer(int id);

        // Movies
        Task<IEnumerable<Movie>> GetMovies(); //
        Task<Movie?> GetMovie(int id); //
        Task<Movie> CreateMovie(MovieDTO movie);
        Task<Movie?> UpdateMovie(int id, MovieDTO movie);
        Task<Movie?> DeleteMovie(int id);

        // Screenings
        Task<IEnumerable<Screening>?> GetScreenings(int id);
        Task<Screening> GetScreening(int id);
        Task<Screening> CreateScreening(ScreeningDTO? screening, int movieId);

        // Tickets
        Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningId);
        Task<Ticket> CreateTicket(int customerId, int screeningId, TicketDTO ticketDTO);

        // MISC
        Task<ApiResponse<T>> GeneratePayload<T>(T data);
        Task<ApiResponse<T>> GenerateErrorPayload<T>(T data, string message);


    }
}
