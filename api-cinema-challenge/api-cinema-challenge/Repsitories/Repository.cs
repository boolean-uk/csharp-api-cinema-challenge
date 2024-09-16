using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repsitories
{
    public class Repository : IRepository
    {
        private CinemaContext _db;
        public Repository(CinemaContext db)
        { 
            _db = db;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }
        public async Task<Movie> AddMovie(Movie movie)
        {
            await _db.AddAsync(movie);
            await _db.SaveChangesAsync();
            return movie;
        }
        public async Task<Movie> UpdateMovie(Movie toUpdate)
        {
            _db.Attach(toUpdate).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return toUpdate;
        }
        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _db.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (movie != null)
            {
                _db.Movies.Remove(movie);
                await _db.SaveChangesAsync();
            }

            return movie;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }
        public async Task<Customer> AddCustomer(Customer customer)
        {
            await _db.AddAsync(customer);
            await _db.SaveChangesAsync();
            return customer;
        }
        public async Task<Customer> UpdateCustomer(Customer toUpdate)
        {
            _db.Attach(toUpdate).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return toUpdate;
        }
        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(m => m.Id == id);

            if (customer != null)
            {
                _db.Customers.Remove(customer);
                await _db.SaveChangesAsync();
            }

            return customer;
        }

        public async Task<IEnumerable<Screening>> GetScreenings(int id)
        {
            var movie = await _db.Movies.Include(m => m.Screenings).FirstOrDefaultAsync(m => m.Id == id);
            return movie.Screenings;
        }
        public async Task<Screening> AddScreening(Screening screening)
        {
            await _db.AddAsync(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

    }
}
