using api_cinema_challenge.Models.Customer;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public CustomerDTO CreateCustomer(string name, string email, string phone)
        {
            Customer customer = null;
            _db.Customers.Add(customer = new Customer() { id = _db.Customers.Max(x => x.id) + 1, name = name, email = email, phone = phone });
            _db.SaveChanges();
            return customer.MapToDTO();
        }

        public List<CustomerDTO> GetCustomers()
        {
            return _db.Customers.ToList().MapListToDTO();
        }
        public CustomerDTO UpdateCustomer(int id, string name, string email, string phone)
        {
            if (_db.Customers.FirstOrDefault(x => x.id == id) != null)
            {
                var customer = new Customer() { id = id, name = name, email = email, phone = phone };
                _db.Customers.Attach(customer);
                _db.Customers.Where(c => c.id == id).ExecuteUpdate(x => x.SetProperty(z => z.name, name).SetProperty(x => x.email, email).SetProperty(x => x.phone, phone));
                return customer.MapToDTO();
            }
            return null;
        }
        public CustomerDTO DeleteCustomer(int id)
        {
            Customer customer = null;
            _db.Customers.Remove(customer = _db.Customers.FirstOrDefault(x => x.id == id));
            _db.SaveChanges();
            return customer != null ? customer.MapToDTO() : null;
        }
    }
}
