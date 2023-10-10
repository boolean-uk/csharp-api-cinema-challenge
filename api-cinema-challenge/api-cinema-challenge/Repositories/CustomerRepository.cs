using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer CreateCustomer(CustomerPost c)
        {
            using (var db = new CinemaContext())
            {
                DateTime date = DateTime.UtcNow;
                Customer customer = new Customer()
                {
                    name = c.name,
                    email = c.email,
                    phone = c.phone,
                    createdAt = date,
                    updatedAt = date
                };

                db.Customers.Add(customer);
                db.SaveChanges();
                return customer;
            }
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            using (var db = new CinemaContext())
            {
                return db.Customers.ToList();
            }
            return null;
        }

        public Customer UpdateCustomer(int id, CustomerPut customerFields)
        {
            using ( var db = new CinemaContext())
            {
                Customer customer = db.Customers.SingleOrDefault(c => c.id == id);
                // TODO: handle case where customer is null

                bool updatedFields = false;

                db.Customers.Attach(customer);
                // update all non-null fields
                if (!string.IsNullOrEmpty(customerFields.name))
                {
                    updatedFields = true;
                    customer.name = customerFields.name;
                }
                if (!string.IsNullOrEmpty(customerFields.email))
                {
                    updatedFields = true;
                    customer.email = customerFields.email;
                }
                if (!string.IsNullOrEmpty(customerFields.phone))
                {
                    updatedFields = true;
                    customer.phone = customerFields.phone;
                }
                if (updatedFields)
                    customer.updatedAt = DateTime.UtcNow;
                db.SaveChanges();
                return customer;
            }
            return null;
        }
    }
}
