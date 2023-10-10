using api_cinema_challenge.Models.Customer;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        bool AddCustomer (Customer customer);
        bool UpdateCustomer (int id, Customer customer);
        bool DeleteCustomer (int id);
        
    }
}
