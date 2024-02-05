using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer?> GetCustomer(int id);
        Task<Customer?> CreateCustomer(string name, string email, string phone);
        Task<Customer>? UpdateCustomer(Customer customer, string? name, string? email, string? phone);
        Task<List<Customer>> DeleteCustomer(Customer customer);
    }
}