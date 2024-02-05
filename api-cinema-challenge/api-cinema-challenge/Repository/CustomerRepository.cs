using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _databaseContext;
        public CustomerRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<Customer> CreateACustomer(Customer customer)
        {

            _databaseContext.Customers.Add(customer);
            SaveChanges();

            GetCustomerById(customer.Id);
            return customer;
        }

        private void SaveChanges()
        {
            _databaseContext.SaveChanges();
        }

        public async Task<Customer?> DeleteACustomer(int id)
        {
            Customer? customerToDelete = await GetCustomerById(id);
            if (customerToDelete == null) { return null; }
            _databaseContext?.Customers.Remove(customerToDelete);
            SaveChanges();
            return customerToDelete;
        }

        public async Task<List<Customer>> GetAll()
        {
            List<Customer> response = await _databaseContext.Customers
                    .Include(c => c.Bookings).ThenInclude(b => b.tickets)
                    .ThenInclude(t => t.seat)
                    .Include(c => c.Bookings).ThenInclude(b => b.tickets)
                    .ThenInclude(t => t.screening).ThenInclude(s => s.Movie)
                    .ToListAsync();
            return response;
        }

        public async Task<Customer?> UpdateACustomer(int id, string name, string email, string phone)
        {
            Customer? customer = await GetCustomerById(id);
            if (customer == null) { return null; }
            customer.Name = name;
            customer.Email = email;
            customer.Phone = phone;
            customer.UpdatedAt = DateTime.UtcNow;
            SaveChanges();
            return customer;

        }
        public async Task<Customer?> GetCustomerById(int id)
        {
            Customer? response = await _databaseContext.Customers
                    .Include(c => c.Bookings).ThenInclude(b => b.tickets)
                    .ThenInclude(t => t.seat)
                    .Include(c => c.Bookings).ThenInclude(b => b.tickets)
                    .ThenInclude(t => t.screening).ThenInclude(s => s.Movie)
                    .FirstOrDefaultAsync(c => c.Id == id);
            if(response == null) { return null; }
            return response;
        }


    }
}
