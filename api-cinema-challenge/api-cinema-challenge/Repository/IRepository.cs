using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> AddCustomer(string name, string email, string phone);
        Task<Customer> UpdateCustomer(int id, string name, string email, string phone);
        Task<Customer> DeleteCustomer(int id);

        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> AddMovie(string title, string rating, string descripition, int runtimemins);
        Task<Movie> UpdateMovie(int id, string title, string rating, string descripition, int runtimemins);
        Task<Movie> DeleteMovie(int id);

        Task<IEnumerable<Screening>> GetScreenings(int id);

        Task<Screening> CreateScreening(int id,int screenNumber,int capacity,DateTime date);






    }
}
