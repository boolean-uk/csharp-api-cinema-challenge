using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int id, Customer newValues);
        Task DeleteCustomer(int id);
    }
}
