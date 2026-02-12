using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int customerId, Customer customer);
        Task<Customer> DeleteCustomer(int customerId);
         

    }
}