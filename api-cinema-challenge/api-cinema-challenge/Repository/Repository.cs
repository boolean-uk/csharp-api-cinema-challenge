using api_cinema_challenge.Data;
using api_cinema_challenge.Models.Customer;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
 /*       public bool AddCustomer(CustomerPost customerPost)
        {
            Customer customer = new Customer();
            customer.Name = customerPost.Name;
            customer.Email = customerPost.Email;
            customer.Phone = customerPost.Phone;
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;
            using (var db = new CinemaContext())
            {
                db.customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            return false;*/
        

        /* public bool AddCustomer(CustomerPut customerPut)
         {
             using (var db = new CinemaContext())
             {
                 db.customerPuts.Add(customerPut);
                 db.SaveChanges();
                 return true;
             }
             return false;
         }*/

        public bool AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                db.customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            Customer? customer = null;

            using (var db = new CinemaContext())
            {
                var targetCustomer = db.customers.FirstOrDefault(c => c.Id == id);
                if (targetCustomer != null)
                {
                    db.Remove(targetCustomer);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Customer GetCustomer(int id)
        {
            Customer? customer = null;

            using (var db = new CinemaContext())
            {
                customer = db.customers.FirstOrDefault(c => c.Id == id);
            }

            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            using (var db = new CinemaContext())
            {
                return db.customers.ToList();
            }
        }

        public bool UpdateCustomer(int id, Customer customer)
        {
            using(var db = new CinemaContext())
            {
               
                if (customer != null)
                {
                    db.customers.Attach(customer);
                    db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                
            }
            return false;
        }
    }
}
