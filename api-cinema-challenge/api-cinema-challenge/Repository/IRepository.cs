using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        public Task<List<Customer>> GetAllCustomers();
    }
}
