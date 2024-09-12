using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories;

public class CustomerRepository(CinemaContext db) : IRepository<Customer>
{
    public async Task<List<Customer>> GetAll()
    {
        return await db.Customers.ToListAsync();
    }

    public async Task<Customer> GetById(int id)
    {
        return (await db.Customers.FirstOrDefaultAsync(p => p.Id == id))!; 
    }

    public async Task<Customer> Add(Customer entity)
    {
        await db.Customers.AddAsync(entity);
        await db.SaveChangesAsync();
        return entity;
    }

    public async Task<Customer> Update(Customer entity)
    {
        var c =  await db.Customers.FirstOrDefaultAsync(p => p.Id == entity.Id);
        c.Name = entity.Name;
        c.Email = entity.Email;
        c.PhoneNumber = entity.PhoneNumber;
        c.UpdatedAt = DateTime.UtcNow;
        await db.SaveChangesAsync();
        return c;
    }

    public async Task<Customer> Delete(Customer entity)
    {
        var c =  await db.Customers.FirstOrDefaultAsync(p => p.Id == entity.Id);
        db.Customers.Remove(c);
        return c;
    }
}