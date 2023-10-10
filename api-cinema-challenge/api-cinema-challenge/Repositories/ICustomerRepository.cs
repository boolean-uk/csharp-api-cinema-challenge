using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface ICustomerRepository
    {
        Customer CreateCustomer(CustomerPost c);
    }
}
