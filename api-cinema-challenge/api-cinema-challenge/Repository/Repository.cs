using api_cinema_challenge.DTO;
using api_cinema_challenge.Payloads;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        public Task<CustomerDTO> CreateCustomer(CustomerPayload payload)
        {
            throw new NotImplementedException();
        }

        public Task<MovieDTO> CreateMovie(MoviePayload payload)
        {
            throw new NotImplementedException();
        }

        public Task<ScreeningDTO> CreateScreening(int movieId, ScreeningPayload payload)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDTO> DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<MovieDTO> DeleteMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieDTO>> GetMovies()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ScreeningDTO>> GetScreenings(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDTO> UpdateCustomer(int customerId, CustomerPayload payload)
        {
            throw new NotImplementedException();
        }

        public Task<MovieDTO> UpdateMovie(int movieId, MoviePayload payload)
        {
            throw new NotImplementedException();
        }
    }
}
