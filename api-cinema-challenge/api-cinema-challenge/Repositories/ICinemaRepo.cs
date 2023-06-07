

using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ICinemaRepo
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer CreateCustomer(Customer customer);
        Customer GetCustomerById(int id);

        Customer UpdateCustomer(Customer customer, int id);

        Customer DeleteCustomer(int id);



    }
}
