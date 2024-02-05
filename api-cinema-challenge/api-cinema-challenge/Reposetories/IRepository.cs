
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Reposetories
{
    public interface IRepository
    {
        Task<Customer> CreateCustomer(string name, string email, string phoneNumber);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer?> UpdateCustomer(int id, string name, string email, string phoneNumber);
        Task<Customer?> DeleteCustomer(int id);


        Task<Ticket?> BookATicket(int customerId, int screeningId, int numSeats);
        Task<IEnumerable<Ticket?>> GetAllBookedTickets();
        Task<IEnumerable<Ticket?>> GetAllCustomersTicketsPerScreaning(int customerId, int screeningId);



        /*--------------------------------------------------------------------------------------------------------------------*/



        Task<Movie> CreateMovie(string title, string rating, string description, int runtimeMins);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie?> UpdateMovie(int id, string title, string rating, string description, int runtimeMins);
        Task<Movie?> DeleteMovie(int id);


        Task<Screening> CreateScreening(int screenNumber, int capasity, DateTime startsAt, int movieid);
        Task<IEnumerable<Screening>> GetScreenings(int movieId);
    }
}
