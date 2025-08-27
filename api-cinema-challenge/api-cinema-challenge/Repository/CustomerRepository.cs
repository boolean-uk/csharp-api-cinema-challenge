using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;


public class CustomerRepository : ICustomerRepository
{
    private readonly CinemaContext _context;

    public CustomerRepository(CinemaContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<Customer?> GetByIdAsync(int id)
    {
        return await _context.Customers.FindAsync(id);
    }

    public async Task<Customer> CreateAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    public async Task<Customer?> UpdateAsync(int id, Customer customer)
    {
        var existingCustomer = await _context.Customers.FindAsync(id);
        if (existingCustomer == null) return null;

        existingCustomer.Name = customer.Name;
        existingCustomer.Email = customer.Email;
        existingCustomer.Phonenumber = customer.Phonenumber;
        existingCustomer.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return existingCustomer;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null) return false;

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return true;
    }
}
