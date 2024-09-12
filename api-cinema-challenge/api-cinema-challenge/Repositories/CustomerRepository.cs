using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;

        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<Customer> CreateCustomer(CreateCustomerDto customerDto)
        {
            Customer customer = new Customer();
            customer.Name = customerDto.Name;
            customer.Email = customerDto.Email;
            customer.Phone = customerDto.Phone;
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;

            await _db.AddAsync(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if(customer == null)
            {
                return null;
            }
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<ICollection<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(int id, CreateCustomerDto customerDto)
        {
            Customer customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);

            if(customer == null)
            {
                return null;
            }

            customer.Name = customerDto.Name;
            customer.Email = customerDto.Email;
            customer.Phone = customerDto.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return customer;
        }
    }
}
