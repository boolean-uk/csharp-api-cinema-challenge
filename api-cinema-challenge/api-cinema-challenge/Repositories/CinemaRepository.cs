using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        private CinemaContext _db;



        public CinemaRepository (CinemaContext db) { 
            _db = db;
        }


        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.Customers.ToListAsync();

        }
        public async Task<Customer?> CreateCustomer(string name, string email, string phone, CreateCustomerPayload payload)
        {
            
            var costumer = new Customer { Name = payload.Name, Email = payload.Email, Phone = payload.Phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            _db.Customers.Add(costumer);
            await _db.SaveChangesAsync();
            return costumer;
        }

        public async Task<Customer?> UpdateCustomer(int id, string name, string email, string phone, UpdateCustomerPayload payload)
        {
           var customer = await _db.Customers.FindAsync(id);
            if (customer == null || string.IsNullOrEmpty(payload.Name) || string.IsNullOrEmpty(payload.Email) || string.IsNullOrEmpty(payload.Phone))
            {
                return null;
            }
            customer.Name = payload.Name;
            customer.Email = payload.Email;
            customer.Phone = payload.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return customer;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            var customer = await _db.Customers.FindAsync(id);
            if (customer == null)
            {
                return false;
            }

            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            return true;
        }


        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _db.Movies.ToListAsync();
        }
        public async Task<Movie?> CreateMovie(string title, string rating, string description, int runTimeMinutes, CreateMoviePayload payload)
        {

            var movie = new Movie
            {
                Title = payload.Title,
                Rating = payload.Rating,
                Description = payload.Description,
                RuntimeMins = payload.RunTimeMinutes,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();

            return movie;
        }

        public async Task<bool> DeleteMovie(int id)
        {
            var movie = await _db.Movies.FindAsync(id);

            if (movie == null)
            {
                return false;
            }

            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            return true;
        }

      
        public async Task<Movie?> UpdateMovie(int id, UpdateMoviePayload payload)
        {
            var movie = await _db.Movies.FindAsync(id);

            if (movie == null)
            {
                return null;
            }
         
            movie.Title = payload.Title;
            movie.Rating = payload.Rating;
            movie.Description = payload.Description;
            movie.RuntimeMins = payload.RunTimeMinutes;
            movie.UpdatedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();

            return movie;
        }
        public async Task<Movie?> CreateMovie(CreateMoviePayload payload)
        {
          
            var movie = new Movie
            {
                
                Title = payload.Title,
                Rating = payload.Rating,
                Description = payload.Description,
                RuntimeMins = payload.RunTimeMinutes,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _db.Movies.Add(movie);
            await _db.SaveChangesAsync();

            return movie;
        }

        public async Task<Screening?> CreateScreening(CreateScreeningPayload payload)
        {
            
             var screening = new Screening
             {
                 MovieId = payload.MovieId,
                 ScreenNumber = payload.ScreenNumber,
                 Capacity = payload.Capacity,
                 StartsAt = payload.StartTime,
                 CreatedAt = DateTime.UtcNow,
                 UpdatedAt = DateTime.UtcNow
             };

             await _db.Screenings.AddAsync(screening);
             await _db.SaveChangesAsync();
             return screening;

            /*
            var movie = _db.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                return null;
            }
            var screening = new Screening
            {
                MovieId = payload.MovieId,
                ScreenNumber = payload.ScreenNumber,
                Capacity = payload.Capacity,
                StartsAt = payload.StartTime,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            _db.SaveChanges();
            return screening;
            */
        }


     

         public async Task<ICollection<Screening>> GetAllScreeningsByMovieID(int movieId)
         {
            /*
             if (movieId < 0)
             {
                 return null;
             }
             var screenings = await _db.Screenings.Where(s => s.MovieId == movieId).ToListAsync();
             await _db.SaveChangesAsync();
             return screenings;
            */
            var movie = await _db.Movies.Include(movie => movie.Screenings)
                .FirstOrDefaultAsync(x => x.Id == movieId);
            if (movie == null)
            {
                return null;
            }

            return movie.Screenings;

        }


        // Ticket
        public async Task<Ticket?> CreateTicket(CreateTicketPayload payload)
        {
            DateTime utc = DateTime.Now.ToUniversalTime();
            var ticket = new Ticket
            {
                numSeats = payload.SeatNumber,
                CustomerId = payload.CustomerId,
                ScreeningId = payload.ScreeningId,
                CreatedAt = utc,
                UpdatedAt = utc
            };

            await _db.Tickets.AddAsync(ticket);
            await _db.SaveChangesAsync();
            return ticket;
        }

        public async Task<ICollection<Ticket>> GetAllTicketsByCustomerAndScreeningID(int customerId, int screeningId)
        {
            if (customerId == null || screeningId == null)
            {
                return null;
            }
            var tickets = await _db.Tickets.Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId).ToListAsync();
            return tickets;
        }

        public async Task<ICollection<Ticket>> GetAllTicketsByCustomerID(int customerId)
        {
            if (customerId == null)
            {
                return null;
            }
            var tickets = await _db.Tickets.Where(t => t.CustomerId == customerId).ToListAsync();
            return tickets;
        }

        public async Task<ICollection<Ticket>> GetAllTicketsByScreeningID(int screeningId)
        {
            if (screeningId == null)
            {
                return null;
            }
            var tickets = await _db.Tickets.Where(t => t.ScreeningId == screeningId).ToListAsync();
            return tickets;
        }


    }
}
