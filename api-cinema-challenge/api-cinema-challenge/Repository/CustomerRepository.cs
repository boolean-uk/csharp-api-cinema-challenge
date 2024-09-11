using api_cinema_challenge.Models.Customer;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public CustomerDTO CreateCustomer(string name, string email, string phone)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDTO> GetCustomers() { throw new NotImplementedException(); }
        public CustomerDTO UpdateCustomer(int id, string name, string email, string phone) { throw new NotImplementedException(); }
        public CustomerDTO DeleteCustomer(int id) { throw new NotImplementedException(); }
    }
}
