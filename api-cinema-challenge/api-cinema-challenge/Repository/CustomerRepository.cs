using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _databaseContext;
        public CustomerRepository(CinemaContext db)
        {
            _databaseContext = db;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var tasks = _databaseContext.Customers.ToListAsync();
            return await tasks;
        }
        public async Task<Customer>? GetCustomer(int id)
        {
            var task = await _databaseContext.Customers.FirstOrDefaultAsync(t => t.Id == id);
            return task;
        }

        public async Task<Customer?> CreateCustomer(string name, string email, string phone)
        {
            List<Customer> customers = _databaseContext.Customers.ToList();
            int nrCustomers = await _databaseContext.Customers.CountAsync();
            int id = customers.Last().Id;
            id++;

            for (int i = 0; i < nrCustomers; i++)
            {
                if (customers[i].Name == name)
                    return null;
            }

            var newCustomer = new Customer() { Id = id, Name = name, Email = email, Phone = phone, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() };
            await _databaseContext.AddAsync(newCustomer);
            await _databaseContext.SaveChangesAsync();
            return newCustomer;
        }

        public async Task<Customer>? UpdateCustomer(Customer customer, string? name, string? email, string? phone)
        {
            bool hasUpdate = false;
            List<Customer> customerList = _databaseContext.Customers.ToList();
            int nrCustomers = await _databaseContext.Customers.CountAsync();

            if (name != null)
            {
                for (int i = 0; i < nrCustomers; i++)
                {
                    if (customerList[i].Name == name)
                        return null;
                }

                customer.Name = name;
                hasUpdate = true;
            }

            if (email != null)
            {
                customer.Email = email;
                hasUpdate = true;
            }

            if (phone != null)
            {
                customer.Phone = phone;
                hasUpdate = true;
            }

            if (!hasUpdate) throw new Exception("No update data provided");
            
            customer.UpdatedAt = DateTime.Now.ToUniversalTime();
            await _databaseContext.SaveChangesAsync();
            return customer;
        }

        public async Task<List<Customer>> DeleteCustomer(Customer customer)
        {
            _databaseContext.Customers.Remove(customer);
            await _databaseContext.SaveChangesAsync();
            return await _databaseContext.Customers.ToListAsync();
        }
    }
}
