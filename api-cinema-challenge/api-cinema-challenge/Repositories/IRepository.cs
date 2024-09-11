using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        Task<ICollection<Customer>> GetAllCustomers();
        Task<Customer> GetACustomer(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int id);
    }
}
