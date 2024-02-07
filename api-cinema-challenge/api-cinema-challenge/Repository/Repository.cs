using api_cinema_challenge.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.DTO;
using System.Numerics;
using System.Xml.Linq;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }


        //************************ Customer *************************************************

        //*********************** Create a customer ****************************************
        public async Task<Customer?> CreateCustomer(string name, string email, string phone)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
                return null;

            var customer = new Customer { Name = name, Email = email, Phone = phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };

            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();

            return customer;
        }


        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync(); 
        }

        public async Task<Customer?> GetCustomer(int customerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            if (preloadPolicy == PreloadPolicy.PreloadRelations)
            {
                return await _db.Customers.Include(c => c.Phone).SingleOrDefaultAsync(c => c.Id == customerId);
            }
            else
            {
                return await _db.Customers.FirstOrDefaultAsync(c => c.Id == customerId);
            }
        }

        public async Task<Customer?> UpdateCustomer(int customerId, string name, string email, string phone, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var customer = await GetCustomer(customerId, preloadPolicy);
            if (customer == null)
                return null;

            customer.Name = name;
            customer.Email = email;
            customer.Phone = phone;
            customer.UpdatedAt = DateTime.UtcNow;

            _db.SaveChanges();

            return customer;
        }


        public async Task<Customer?> DeleteCustomer(int customerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var customerRemoved = await _db.Customers.FirstOrDefaultAsync(x => x.Id == customerId);
            if (customerRemoved == null) return null;

            _db.Customers.Remove(customerRemoved);
            _db.SaveChanges();
            return customerRemoved;
        }



        //***************************** Movie *********************************

        public async Task<Movie> CreateMovie(string title, string rating, string description, int runtime)
        {

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(rating) || string.IsNullOrEmpty(description) || runtime <= 0)
            {
                return null;
            }

            var movie = new Movie 
            { 
                Title = title, 
                Rating = rating,
                Description = description,
                Runtime = runtime,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();

            return movie;
        }


        // *************************** Get Movies   *********************************
        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }



        //***************************** Get all movies ******************************
        public async Task<Movie> GetAllMovies(int movieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            if (preloadPolicy == PreloadPolicy.PreloadRelations)
            {
                return await _db.Movies.Include(c => c.Runtime).SingleOrDefaultAsync(c => c.Id == movieId);
            }
            else
            {
                return await _db.Movies.FirstOrDefaultAsync(c => c.Id == movieId);
            }
        }

        //***************************** Update movie *******************************
        public async Task<Movie> UpdateMovie(int id, string title, string rating, string description, int runetime, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var movie = await GetAllMovies(id, preloadPolicy);
            if (movie == null)
            {
                return null;
            }

            movie.Title = title;
            movie.Rating = rating;
            movie.Description = description;
            movie.Runtime = runetime;
            movie.UpdatedAt = DateTime.UtcNow;

            _db.SaveChanges();  
            return movie;

        }



        public async Task<Movie> DeleteMovie(int id, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var found = await _db.Movies.Include(a =>a.Screenings).FirstOrDefaultAsync(x => x.Id == id);
            if (found == null)
            {
                return null;
            }

            List<Screening> screnings = _db.Screenings.Where(a => a.MovieId == found.Id).ToList();

            foreach(Screening screening in screnings)
            {
                _db.Screenings.Remove(screening);
            }

            _db.Movies.Remove(found);

            _db.SaveChanges();
            return found;
        }





        //******************************* Screening *****************************************
        public async Task<Screening> CreateScreening(int screenNumber, int capacity, DateTime datetime, int movieId)
        {
            if (screenNumber <= 0|| capacity <= 0 )
            {
                return null;
            }

            var screening = new Screening
            {
                ScreanNumber = screenNumber,
                Capacity = capacity,
                MovieId = movieId,
                StartsAt = datetime,
                CreatedAt = datetime,
                UpdatedAt = datetime,
            };

            await _db.Screenings.AddAsync(screening);
            await _db.SaveChangesAsync();
            return screening;

        }


        public async Task<IEnumerable<Screening>> GetAllScreenings()
        {
            return await _db.Screenings.ToListAsync();
        }


        public void SaveChanges()
        {
            _db.SaveChanges();
        }


        //***************************** Ticket *****************************
        public async Task<Ticket> CreateTicket(int numSeat, int customerId, int screeningId, DateTime Date)
        {
            if (numSeat <= 0)
            {
                return null;
            }

            Ticket ticket = new Ticket
            {
                numSeat = numSeat,
                customerId = customerId,
                screeningId = screeningId,
                CreatedAt = Date,
                UpdatedAt = Date
                
            };

            await _db.Tickets.AddAsync(ticket);

            await _db.SaveChangesAsync();
            return ticket;
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            return await _db.Tickets.ToListAsync();
        }







        




    }
}
