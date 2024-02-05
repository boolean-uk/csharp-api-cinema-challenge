using api_cinema_challenge.Models;
using api_cinema_challenge.Endpoints;

namespace api_cinema_challenge.Repositories
{

    public enum PreloadPolicy
    {
        DoNotPreloadRelations,
        PreloadRelations
    }

    public interface ICinemaRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();

        Task<Customer?> CreateCustomer(string name, string email, string phone, CreateCustomerPayload payload);

        Task<Customer?> UpdateCustomer(int id, string name, string email, string phone, UpdateCustomerPayload payload);

        Task<bool> DeleteCustomer(int id);

        Task<IEnumerable<Movie>> GetAllMovies();

        Task<Movie?> CreateMovie(string title, string rating, string description, int runTimeMinutes, CreateMoviePayload payload);

        Task<Movie?> UpdateMovie(int id, string title, string rating, string description, int runTimeMinutes, UpdateMoviePayload payload);

        Task<bool> DeleteMovie(int id);

        Task<ICollection<Screening>> GetAllScreeningsByMovieID(int movieId);

        Task<Screening?> CreateScreening(int movieId, int screenNumber, int capacity, DateTime startTime, CreateScreeningPayload payload);

        Task<Ticket?> CreateTicket(int seatNumber, int customerId, int screeningId, CreateTicketPayload payload);
        Task<ICollection<Ticket>> GetAllTicketsByCustomerAndScreeningID(int customerId, int screeningId);
    }
}