using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;
        public CustomerRepository(CinemaContext db) 
        {
            _db = db;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();

        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            _db.Add(customer);

            await _db.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            var existingCustomer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (existingCustomer == null)
                throw new KeyNotFoundException("Customer not found");

            existingCustomer.UpdatedAt = DateTime.UtcNow;

            if (!string.IsNullOrEmpty(customer.Name))
                existingCustomer.Name = customer.Name;

            if (!string.IsNullOrEmpty(customer.Email))
                existingCustomer.Email = customer.Email;

            if (!string.IsNullOrEmpty(customer.Phone))
                existingCustomer.Phone = customer.Phone;

            _db.Customers.Update(existingCustomer);
            await _db.SaveChangesAsync();

            return existingCustomer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var existingCustomer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (existingCustomer == null)
                throw new KeyNotFoundException("Customer not found");

            _db.Customers.Remove(existingCustomer);

            await _db.SaveChangesAsync();

            return existingCustomer;
        }
    }
}
