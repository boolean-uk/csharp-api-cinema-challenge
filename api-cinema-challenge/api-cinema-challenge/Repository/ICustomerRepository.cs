using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICustomerRepository
    {
        public Task<Customer> CreateACustomer(Customer customer);
        public Task<List<Customer>> GetAll();
        public Task<Customer> UpdateACustomer(int id, string name, string email, string phone);
        public Task<Customer?> DeleteACustomer(int id);

    }
}
