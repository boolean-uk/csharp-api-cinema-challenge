using api_cinema_challenge.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private DataContext _db;

        public Repository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Customer>> GetCustomersWithScreening()
        {
            return await _db.Customers.Include(s => s.screening).ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetCustomersWithoutScreening()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _db.Customers.Include(s => s.screening).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Customer> CreateCustomer(Customer entity)
        {
            await _db.Customers.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> UpdateCustomer(Customer entity)
        {
            _db.Attach(entity).State = EntityState.Modified;
            //await _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _db.Customers.Include(s => s.screening).FirstOrDefaultAsync(x => x.Id == id);

            if (customer != null)
            {

                _db.Customers.Remove(customer);
                await _db.SaveChangesAsync();
                
            }
            return customer;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Movie> CreateMovie(Movie entity)
        {
            await _db.Movies.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Movie> UpdateMovie(Movie entity)
        {
            _db.Movies.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (movie != null)
            {
                _db.Movies.Remove(movie);
                await _db.SaveChangesAsync();
             
            }
            return movie;
            
        }
    }

}
