using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            List<Customer> customers = await _db.Customers.ToListAsync();
            return customers;
        }
    }
}
