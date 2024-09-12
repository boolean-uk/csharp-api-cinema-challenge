using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        public Task<CustomerDTO> AddCustomer(Customer entity);
        public Task<ICollection<CustomerDTO>> GetCustomers();
        public Task<CustomerDTO> UpdateCustomer(int id, Customer entity);
        public Task<CustomerDTO> RemoveCustomer(int id);
        public Task<MovieDTO> AddMovie(Movie entity);
        public Task<ICollection<MovieDTO>> GetMovies();
        public Task<MovieDTO> UpdateMovie(int id, Movie entity);
        public Task<MovieDTO> RemoveMovie(int id);
        public Task<ScreeningDTO> AddScreening(Screening entity);
        public Task<ICollection<ScreeningDTO>> GetScreenings(int id);
    }
}
