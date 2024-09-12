using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        Task<Customer> CreateCustomer(Customer entity);
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> UpdateCustomer(int id, Customer entity);
        Task<Customer> DeleteCustomer(int id);
    }
}
