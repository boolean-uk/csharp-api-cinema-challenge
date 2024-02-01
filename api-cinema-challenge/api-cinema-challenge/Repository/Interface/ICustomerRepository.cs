
using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interface {
    public interface ICustomerRepository {

        Task<Customer> CreateCustomer(string name, string email, string phone);
        Task<Customer?> GetCustomer(int Id);

        Task<Customer> UpdateCustomer (int id, Customer customer, Customer newCustomer);
        Task DeleteCustomer(int id);
        Task<IEnumerable<Customer>> GetAllCustomers();
    }
}
