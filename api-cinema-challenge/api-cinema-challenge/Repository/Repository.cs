using System.Net.Quic;
using System.Numerics;
using System.Xml.Linq;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        CinemaContext cc;

        public Repository(CinemaContext cc)
        {
            this.cc = cc;
        }

        public async Task<Customer> AddCustomer(string name, string email, string phone)
        {
            Customer customer = new Customer
            {
                Name = name,
                Email = email,
                Phone = phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await cc.Customers.AddAsync(customer);
            await cc.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> AddMovie(string title, string rating, string description, int runtimemins)
        {
            Movie movie = new Movie
            {
                Title = title,
                Rating = rating,
                Description = description,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await cc.Movies.AddAsync(movie);
            await cc.SaveChangesAsync();
            return movie;
        }

        public async Task<Screening> CreateScreening(int id, int screenNumber, int capacity, DateTime dateTime)
        {
            var movie = await cc.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return null;
            }

            var screening = new Screening
            {
                ScreenNumber = screenNumber,
                Capacity = capacity,
                Movie = movie,
                MovieId = movie.Id,
                StartsAt = dateTime.ToUniversalTime(), // Konverter input til UTC
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await cc.Screenings.AddAsync(screening);
            await cc.SaveChangesAsync();
            return screening;
        }

        public async Task<Customer> DeleteCustomer(int id)
        {
            var customer = await cc.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customer == null)
            {
                return null;
            }

            cc.Customers.Remove(customer);
            await cc.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await cc.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return null;
            }

            cc.Movies.Remove(movie);
            await cc.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await cc.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await cc.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Screening>> GetScreenings(int id)
        {
            return await cc.Screenings.Include(x => x.Movie).Where(x => x.MovieId == id).ToListAsync();
        }

        public async Task<Customer> UpdateCustomer(int id, string name, string email, string phone)
        {
            var customer = await cc.Customers.FirstOrDefaultAsync(x => x.Id == id);

            if (customer == null)
            {
                return null;
            }

            customer.Name = name;
            customer.Email = email;
            customer.Phone = phone;
            customer.UpdatedAt = DateTime.UtcNow;

            await cc.SaveChangesAsync();
            return customer;
        }

        public async Task<Movie> UpdateMovie(int id, string title, string rating, string description, int runtimemins)
        {
            var movie = await cc.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (movie == null)
            {
                return null;
            }

            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.UpdatedAt = DateTime.UtcNow;

            await cc.SaveChangesAsync();
            return movie;
        }
    }
}
