using api_cinema_challenge.Models;
using System.Net.Mail;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {

        public Task<IEnumerable<Customer>> GetCustomers();
        public Task<Customer?> GetCustomer(int id);
        public Task<Customer?> UpdateCustomer(int id, string newName, string newEmail, string newPhone);
        public Task<Customer?> CreateCustomer(string name, string email, string phone);
        public Task<Customer?> DeleteCustomer(int id);

        public Task<IEnumerable<Movie>> GetMovies();
        public Task<Movie?> GetMovie(int id);
        public Task<Movie?> UpdateMovie(int id, string title, string rating, string description, int runtimeMins);
        public Task<Movie?> CreateMovie(string title, string rating, string description, int runtimeMins);
        public Task<Movie?> DeleteMovie(int id);

        public Task<IEnumerable<Screenings>> GetScreenings(int movieId);
        public Task<Screenings?> GetScreening(int id);
        public Task<Screenings?> CreateScreening(int movieID, int screenNumber, int capacity, DateTime StartsAt);

        public Task<Ticket?> BookTicket(int customerID, int screeningID, int numSeats);
        public Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningID);
        public bool IsValidEmail(string email);
        public Task<int> GetNumberOfAvailableSeats(int screeningID);
    }
}
