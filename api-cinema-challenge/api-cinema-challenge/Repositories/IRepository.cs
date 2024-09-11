
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        Task<Customer> AddCustomer(string name, string email, string phonenumber);
        Task<Movie> AddMovie(string title, string rating, string description, int runtimeMins);
        Task<Customer> DeleteCustomer(int id);
        Task<Movie> DeleteMovie(int id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<IEnumerable<Movie>> GetMovie();
        Task<Customer> UppdateCustomer(int id, string? name, string? email, string? phone);
        Task<Movie> UppdateMovie(int id, string? title, string? rating, string? description, int? runtimeMins);
    }
}
