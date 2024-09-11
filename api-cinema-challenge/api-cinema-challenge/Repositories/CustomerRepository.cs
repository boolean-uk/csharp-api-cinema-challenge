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

    public Task<Customer> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> Update(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> Delete(Customer entity)
    {
        throw new NotImplementedException();
    }
}