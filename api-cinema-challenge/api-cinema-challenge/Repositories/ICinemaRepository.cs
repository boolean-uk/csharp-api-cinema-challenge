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

        Task<Customer?> CreateCustomer(CreateCustomerPayload payload);

        Task<Customer?> UpdateCustomer(int id, UpdateCustomerPayload payload);

        Task<bool> DeleteCustomer(int id);

        Task<IEnumerable<Movie>> GetAllMovies();

        Task<Movie?> CreateMovie(CreateMoviePayload payload);

        Task<Movie?> UpdateMovie(int id, UpdateMoviePayload payload);

        Task<bool> DeleteMovie(int id);

        Task<ICollection<Screening>> GetAllScreeningsByMovieID(int movieId);

        Task<Screening?> CreateScreening(CreateScreeningPayload payload);

        Task<Ticket?> CreateTicket(CreateTicketPayload payload);
        Task<ICollection<Ticket>> GetAllTicketsByCustomerAndScreeningID(int customerId, int screeningId);

        Task<ICollection<Ticket>> GetAllTicketsByCustomerID(int customerId);

        Task<ICollection<Ticket>> GetAllTicketsByScreeningID(int screeningId);

    }
}