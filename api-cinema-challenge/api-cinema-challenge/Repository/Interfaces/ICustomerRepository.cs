using api_cinema_challenge.Model;

namespace api_cinema_challenge.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(int id);
        Task<Customer> CreateCustomer(string name , string email , string phone);
        Task<Customer> UpdateCustomer(int id , string name , string email , string phone);
        Task<Customer> DeleteCustomer(int id);
    }
}
