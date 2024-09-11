using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository
    {
        Task<ICollection<Customer>> GetAll();
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int id);
    }
}
