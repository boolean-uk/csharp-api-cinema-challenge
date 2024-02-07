using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories.customer
{
    public interface ICustomerRepository
    {
        public Task<Customer> Add(string name, string email, string phone);
        public Task<List<Customer>> GetAll();
        public Task<Customer?> Get(int id);
        public Task<Customer?> Update(int id, string name, string email, string phone);
        public Task<Customer?> Delete(int id);
    }
}
