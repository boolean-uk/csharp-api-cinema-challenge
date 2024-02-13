using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _cinemaContext;
        public CustomerRepository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<Customer> CreateCustomer(string name, string email, string phone)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.Email = email;
            customer.Phone = phone;
            customer.CreatedAt = DateTime.Now.ToUniversalTime();
            customer.UpdatedAt = DateTime.Now.ToUniversalTime();
            await _cinemaContext.Customers.AddAsync(customer);
            _cinemaContext.SaveChanges();
            return customer;
        }

        public async Task<Customer> DeleteCustomer(Customer customer)
        {
            _cinemaContext.Customers.Remove(customer);
            await _cinemaContext.SaveChangesAsync();
            return customer;

        }

        public async Task<Customer?> GetCustomerByID(int id)
        {
            return await _cinemaContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _cinemaContext.Customers.ToListAsync();
        }

        public Customer UpdateCustomer(Customer customer, string? name, string? email, string? phone)
        {
            if (name is not null) customer.Name = name;
            if (email is not null) customer.Email = email;
            if (phone is not null) customer.Phone = phone;
            customer.UpdatedAt = DateTime.Now.ToUniversalTime();
            _cinemaContext.SaveChanges();
            return customer;
        }
    }
}
