using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class CinemaRepo : ICinemaRepo
    {
        public Customer CreateCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
               db.Customers.Add(customer);
                db.SaveChanges();
                return customer;
            }

        }

        public Customer DeleteCustomer(int id)
        {
            using (var db = new CinemaContext())
            {
                var deleteCusomer = db.Customers.FirstOrDefault(c => c.Id == id);
                if (deleteCusomer != null)
                {
                    db.Customers.Remove(deleteCusomer);
                    db.SaveChanges() ;
                    return deleteCusomer;

                }
                return null;
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            using(var db = new CinemaContext())
            {
                return db.Customers.ToList();
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (var db = new CinemaContext())
            {
                var deleteCusomer = db.Customers.FirstOrDefault(c => c.Id == id);
                if (deleteCusomer != null)
                {
                    
                    return deleteCusomer;

                }
                return null;
            }
        }

        public Customer UpdateCustomer(Customer customer, int id)
        {
            using (var db = new CinemaContext())
            {
                var updatedCustomer = db.Customers.FirstOrDefault(c => c.Id == id);
                if (updatedCustomer != null)
                {
                    updatedCustomer.Id = id;
                    updatedCustomer.Name = customer.Name;
                    updatedCustomer.Email = customer.Email;
                    updatedCustomer.Phone = customer.Phone;
                    updatedCustomer.UpdatedDate = DateTime.UtcNow;
                    db.SaveChanges();
                    return updatedCustomer;

                }
                return null;
            }
        }
    }
}
