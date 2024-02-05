using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }


        /// CUSTOMERS
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer?> GetCustomer(int CustomerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            switch (preloadPolicy)
            {
                case PreloadPolicy.PreloadRelations:
                    return await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);
                case PreloadPolicy.DoNotPreloadRelations:
                    return await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);
                default:
                    return null;
            }
        }

        public async Task<Customer?> DeleteCustomer(int CustomerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var mv = await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);

            if (mv == null)
            {
                return null;
            }

            _db.Customers.Remove(mv);

            return mv;
        }

        public async Task<Customer?> CreateCustomer(string name, string email, string phone)
        {
            if (name == "" || email == "" || phone == "") return null;
            var customer = new Customer { Name = name, Email = email, Phone = phone, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt =  DateTime.Now.ToUniversalTime()  };
            await _db.Customers.AddAsync(customer);
            return customer;
        }

        public async Task<Customer?> UpdateCustomer(int CustomerId, string name, string email, string phone, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var mv = await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);

            if (mv == null)
            {
                return null;
            }

            if (name != null) { mv.Name = name; }

            if (email != null) { mv.Email = email; }

            if (phone != null) { mv.Phone = phone; }

            mv.UpdatedAt = DateTime.Now.ToUniversalTime();

            return mv;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
