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
    }
}
