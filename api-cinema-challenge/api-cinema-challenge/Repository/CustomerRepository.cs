using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                customer.CreatedAt = DateTime.UtcNow;
                db.Customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            using (var db = new CinemaContext())
            {
                db.Remove(db.Customers.Find(id));
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Customer GetCustomer(int id)
        {
            Customer result;
            using (var db = new CinemaContext())
            {
                result = db.Customers.Find(id);
                db.SaveChanges();
                return result;
            }
            return result;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            using (var db = new CinemaContext())
            {
                return db.Customers.ToList();
            }
            return null;
        }

        public bool UpdateCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                customer.UpdatedAt = DateTime.UtcNow;
                db.Update(customer);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
