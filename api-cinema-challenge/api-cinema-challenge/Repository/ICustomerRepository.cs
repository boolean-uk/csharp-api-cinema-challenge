using System.Linq.Expressions;
using api_cinema_challenge.Models;


namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository 
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> UpdateCustomer(int id, Customer customer);

        Task<Customer> DeleteCustomer(int id);
    }
}