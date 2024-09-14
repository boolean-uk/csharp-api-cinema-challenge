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

        // Customer CRUD
        public async Task<Customer> CreateCustomer(Customer entity)
        {
            _db.Customers.Add(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers
                .Include(a => a.Screening)
                .ThenInclude(b => b.Movie)
                .ToListAsync();
        }
        public async Task<Customer> GetCustomerById(int customerId)
        {
            var entity = await _db.Customers
                .Include(a => a.Screening)
                .ThenInclude(b => b.Movie)
                .FirstOrDefaultAsync(c => c.Id == customerId);

            if (entity == null)
                throw new Exception($"Customer with id {customerId} does not exist.");

            return entity;
        }

        public async Task<Customer> UpdateACustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> DeleteACustomer(int customerId)
        {
            var entity = await _db.Customers.FirstOrDefaultAsync(x => x.Id == customerId);

            if (entity == null)
                throw new Exception($"Customer with id {customerId} does not exist.");

            _db.Customers.Remove(entity);

            await _db.SaveChangesAsync();

            return entity;
        }

        // Movies CRUD
        public async Task<Movie> CreateMovie(Movie entity)
        {
            _db.Movies.Add(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieById(int movieId)
        {
            var entity = await _db.Movies.FirstOrDefaultAsync(a => a.Id == movieId);

            if (entity == null)
                throw new Exception($"Movie with id {movieId} does not exist.");

            return entity;
        }

        public async Task<Movie> UpdateAMovie(int movieId)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> DeleteAMovie(int movieId)
        {
            var target = await _db.Movies.FirstOrDefaultAsync(x => x.Id == movieId);

            if (target == null)
                throw new Exception($"Movie with id {movieId} does not exist.");

            _db.Movies.Remove(target);

            await _db.SaveChangesAsync();

            return target;
        }

        // Screenings
        public async Task<Screening> CreateScreening(Screening entity)
        {
            _db.Screenings.Add(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<Screening>> GetAllScreenings(int movieId)
        {
            return await _db.Screenings
                .Where(s => s.MovieId == movieId)
                .Include(a => a.Movie)
                .ToListAsync();
        }

        public async Task<Screening> GetScreeningById(int screeningId)
        {
            var entity = await _db.Screenings
                .Include(a => a.Movie)
                .FirstOrDefaultAsync(b => b.Id == screeningId);

            if (entity == null)
                throw new Exception($"Screening with id {screeningId} does not exist.");

            return entity;
        }
    }
}
