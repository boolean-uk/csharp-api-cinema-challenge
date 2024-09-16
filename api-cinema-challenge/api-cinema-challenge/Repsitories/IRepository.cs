using System.Threading.Tasks;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repsitories
{
    public interface IRepository
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie toUpdate);
        Task<Movie> DeleteMovie(int id);

        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer toUpdate);
        Task<Customer> DeleteCustomer(int id);

        Task<IEnumerable<Screening>> GetScreenings(int id);
        Task<Screening> AddScreening(Screening screening);
    }
}
