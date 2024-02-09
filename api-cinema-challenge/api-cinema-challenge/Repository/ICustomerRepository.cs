using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        Task<Customer> CreateCustomer(Customer request);

        Task<IEnumerable<Customer>> GetCustomers();

        Task<Customer> UpdateCustomer(Customer request);

        Task<Customer> DeleteCustomer(Customer request);

        Task<Customer> GetCustomerById(CustomerDTO request);
        Task<Customer> GetCustomerById(int id);
    }
}
