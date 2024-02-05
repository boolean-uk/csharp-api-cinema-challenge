using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Posts;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRespository
    {
        public Task<Customer> AddCustomer(Customer customer);
        public Task<ICollection<Customer>> GetAllCustomers();
        public Task<Customer?> UpdateCustomer(int id, CustomerPost customer);
        public Task<Customer?> DeleteCustomer(int id);
    }
}
