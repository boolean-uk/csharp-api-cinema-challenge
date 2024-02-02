using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{

    public enum PreloadPolicy
    {
        PreloadRelations,
        DoNotPreloadRelations
    }

    public interface IRepository
    {
        

        // MOVIES
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie?> GetMovie(int movieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Movie?> CreateMovie(string title, string rating, string description, int runtimemins);
        Task<Movie?> DeleteMovie(int movieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Movie?> UpdateMovie(int movieId, string title, string rating, string description, int runtimemins, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);



        // CUSTOMERS
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer?> GetCustomer(int CustomerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Customer?> CreateCustomer(string name, string email, string phone);
        Task<Customer?> DeleteCustomer(int customerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Customer?> UpdateCustomer(int customerId, string name, string email, string phone, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);


        // SCREENINGS
        Task<IEnumerable<Screening>> GetScreenings(int id);
        // Task<Screening?> GetScreening(int screeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Screening?> CreateScreening(int screennumber, int capacity, DateTime datetime, int movieId);
        // Task<Screening?> DeleteScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        // Task<Screening?> UpdateScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);


        // TICKETS
        Task<IEnumerable<Ticket>> GetTickets(int custId, int screenId);
        // Task<Screening?> GetScreening(int screeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Ticket?> CreateTicket(int custId, int screenId, int seatNums);
        // Task<Screening?> DeleteScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        // Task<Screening?> UpdateScreening(int ScreeningId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);

        public void SaveChanges();

    }
}
