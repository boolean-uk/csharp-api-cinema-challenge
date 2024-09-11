using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public async Task<Customer> AddCustomer(string name, string email, string phonenumber)
        {
            await _db.Customers.AddAsync(new Customer(name, email, phonenumber));
            await _db.SaveChangesAsync();
            return new Customer(name, email, phonenumber);
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
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (name is not null) { customer.Name = name; }
            if (email is not null) { customer.Email = email; }
            if (phone is not null) { customer.Phone = phone; }
            await _db.SaveChangesAsync();
            return customer;
        }
    }
}
