using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        public Task<IEnumerable<Customer>> GetCustomers();
        public Task<Customer> CreateCustomer(string name, string email, string phone);
        public Task<Customer> DeleteCustomer(Customer customer);
        public Customer UpdateCustomer(Customer customer, string? name, string? email, string? phone);
        public Task<Customer?> GetCustomerByID(int id);
    }
}
