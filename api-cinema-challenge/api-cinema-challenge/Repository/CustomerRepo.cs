using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        public bool AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
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
                var target = db.Customers.FirstOrDefault(c => c.Id == id);
                if (target != null)
                {
                    // Here in the other applications
                    // we do db.Remove(target) without the
                    // Customers. Why is that?
                    db.Customers.Remove(target);
                    return true;
                }
                return false;
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
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
                var target = db.Customers.FirstOrDefault(c => c.Id ==  customer.Id);
                if (target != null)
                {
                    db.Customers.Attach(target);
                    target.name = customer.name;
                    target.email = customer.email;
                    target.phone = customer.phone;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
