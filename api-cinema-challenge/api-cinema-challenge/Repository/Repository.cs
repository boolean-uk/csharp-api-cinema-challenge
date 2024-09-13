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

        public async Task<Customer> AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Screening> AddScreening(int MovieID, int ScreenID)
        {
            Screening screening = new Screening()
            {
                MovieId = MovieID,
                ScreenId = ScreenID
            };
            _db.Screenings.Add(screening);
            await _db.SaveChangesAsync();
            return screening;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            Customer customer = await _db.Customers.SingleOrDefaultAsync(x => x.Id == id);
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            Movie movie = await _db.Movies.SingleOrDefaultAsync( a => a.Id == id);
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            List<Customer> customers = await _db.Customers.ToListAsync();
            return customers;
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            List<Movie> movies = await _db.Movies.ToListAsync();
            return movies;
        }

        public async Task<List<Screening>> GetAllScreenings(int movieid)
        {
            List<Screening> screenings = await _db.Screenings.Include( a => a.Screen).Include(b=> b.Movie).Where(a => a.MovieId == movieid).ToListAsync();
            return screenings;
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            Customer dbCustomer = await _db.Customers.SingleOrDefaultAsync( a=>  a.Id == id);
            dbCustomer.Name = customer.Name;
            dbCustomer.Email = customer.Email;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.updatedAt = DateTime.UtcNow;

            _db.Attach(dbCustomer).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return dbCustomer;
        }

        public async Task<Movie> UpdateMovie(int id, Movie movie)
        {
            Movie dbMovie = await _db.Movies.SingleOrDefaultAsync(a=> a.Id == id);
            dbMovie.MovieName = movie.MovieName;
            dbMovie.updatedAt = DateTime.UtcNow;
            _db.Attach(dbMovie).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return dbMovie;
        }
    }
}
