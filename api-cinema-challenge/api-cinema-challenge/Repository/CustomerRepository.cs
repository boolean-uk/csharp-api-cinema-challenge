using api_cinema_challenge.Data;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CinemaContext _db;
        public CustomerRepository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<Customer> CreateCustomer(CustomerInputDTO input)
        {
            Customer customer = new Customer()
            {
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime(),
                Name = input.Name,
                Email = input.Email,
                Phone = input.Phone,
                Id = await _db.Customers.MaxAsync(x => x.Id) + 1
            };
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            Customer Org = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (Org == null) { return null; }
            _db.Customers.Remove(Org);
            await _db.SaveChangesAsync();

            return Org;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(CustomerInputDTO input, int id)
        {
            Customer Org = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (Org == null) { return null; }
            Org.UpdatedAt = DateTime.Now.ToUniversalTime();

            if (!string.IsNullOrEmpty(input.Name)) Org.Name = input.Name;
            if (!string.IsNullOrEmpty(input.Email)) Org.Email = input.Email;
            if (!string.IsNullOrEmpty(input.Phone)) Org.Phone = input.Phone;
            await _db.SaveChangesAsync();
            return Org;
        }
    }
}
