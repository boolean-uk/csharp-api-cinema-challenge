using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CinemaContext _context;

        public CustomerRepository(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<Customer> CreateCustomer(string name , string email , string phone)
        {
            var customer = new Customer
            {
                Name = name ,
                Email = email ,
                Phone = phone
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> UpdateCustomer(int id , string name , string email , string phone)
        {
            var customer = await _context.Customers.FindAsync(id);
            if(customer == null)
            {
                return null;
            }

            customer.Name = name;
            customer.Email = email;
            customer.Phone = phone;

            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if(customer == null)
            {
                return null;
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return customer;
        }
    }
}
