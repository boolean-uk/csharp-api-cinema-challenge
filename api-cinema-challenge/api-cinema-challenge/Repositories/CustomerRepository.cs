using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public async Task<Customer> AddCustomer(string name, string email, string phonenumber)
        {
            DateTime dt = DateTime.Now; Console.WriteLine("{0} {1}", dt, dt.Kind);
            DateTime ut = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
            var customer = new Customer() { Id = _db.Customers.Count() + 1, Name = name, Email = email, Phone = phonenumber, CreatedAt = ut, UpdatedAt = ut };
            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            _db.Customers.Remove(customer); 
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> UppdateCustomer(int id, string? name, string? email, string? phone)
        {
            DateTime dt = DateTime.Now; Console.WriteLine("{0} {1}", dt, dt.Kind);
            DateTime ut = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (name is not null) { customer.Name = name; customer.UpdatedAt = ut; }
            if (email is not null) { customer.Email = email; customer.UpdatedAt = ut; }
            if (phone is not null) { customer.Phone = phone; customer.UpdatedAt = ut; }
            await _db.SaveChangesAsync();
            return customer;
        }
    }
}
