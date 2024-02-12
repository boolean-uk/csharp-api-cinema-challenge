using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        //Customer
        Task<IEnumerable<CustomerDTO>> GetCustomers();
        Task<Customer> CreateCustomer(CustomerPost customer, int id);
        Task<Customer> UpdateCustomer(int id, CustomerPost customer);
        Task<Customer> DeleteCustomer(int id);

        //Movie
        Task<IEnumerable<MovieDTO>> GetMovies();
        //Task<Movie> CreateMovie(MoviePost movie, int id);
        Task<Movie> CreateMovie(MoviePost movie, int id);
        Task<Movie> UpdateMovie(int id, MoviePost movie);
        Task<MovieDTO> DeleteMovie(int id);

        //Screening
        Task<IEnumerable<ScreeningDTO>> GetScreeningsForMovie(int movieId);
        Task<Screening> CreateScreeningForMovie(ScreeningPost screening, int movieId);

        //Ticket
        Task<Ticket> BookTicket(int customerId, int screeningId, int numSeats);
        Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningId);
    }
}
