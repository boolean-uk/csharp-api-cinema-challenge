using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();

        Task<Customer> GetCustomerById(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int id, Customer customer);
        Task<Customer> DeleteCustomer(int id);
        
    }
}
