using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        public Task<Customer> GetByIdAsync(int id);
        public Task<IEnumerable<Customer>> GetAllAsync();
        public Task<Customer> CreateCustomer(Customer customer);
        public Task<Customer> UpdateCustomer(Customer customer);
        public Task<Customer> DeleteCustomer(int id);
    }
}
