using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> AddAsync(Customer c);
        Task<List<Customer>> GetAllAsync();
        Task<Customer?> GetAsync(int id);
        Task<Customer?> UpdateAsync(int id, Customer update);
        Task<Customer?> DeleteAsync(int id);
    }
}
