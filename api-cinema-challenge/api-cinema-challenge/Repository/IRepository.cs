using api_cinema_challenge.DTO;
using api_cinema_challenge.Payloads;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<CustomerDTO>> GetCustomers();
        Task<IEnumerable<MovieDTO>> GetMovies();
        Task<IEnumerable<ScreeningDTO>> GetScreenings(int movieId);
        Task<CustomerDTO> CreateCustomer(CustomerPayload payload);
        Task<MovieDTO> CreateMovie(MoviePayload payload);
        Task<ScreeningDTO> CreateScreening(int movieId, ScreeningPayload payload);
        Task<CustomerDTO> UpdateCustomer(int customerId, CustomerPayload payload);
        Task<MovieDTO> UpdateMovie(int movieId, MoviePayload payload);
        Task<CustomerDTO> DeleteCustomer(int customerId);
        Task<MovieDTO> DeleteMovie(int movieId);

    }
}
