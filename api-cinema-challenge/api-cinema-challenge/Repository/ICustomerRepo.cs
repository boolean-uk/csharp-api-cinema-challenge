using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepo
    {
        bool AddCustomer(Customer customer);
        IEnumerable<Customer> GetAllCustomers();
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int id);
    }
}
