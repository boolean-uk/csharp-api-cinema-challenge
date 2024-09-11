using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class Repository : IRepository
    {
        public Task<Customer> CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
