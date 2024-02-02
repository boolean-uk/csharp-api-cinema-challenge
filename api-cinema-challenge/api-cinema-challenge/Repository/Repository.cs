using api_cinema_challenge.Data;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private readonly CinemaContext _context;

        public Repository(CinemaContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer?> GetCustomer(int id)
        {
            return await _context.Customer.Include(c => c.Tickets).FirstOrDefaultAsync(c => c.Id == id);
        }

       

        public bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            // Regular expression for basic email validation
            var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            return regex.IsMatch(trimmedEmail);
        }

        public async Task<Customer?> CreateCustomer(string name, string email, string phone)
        {
            if (name == "" || email == null || phone == "") return null;
            //if(IsValidEmail(email) == false) { return null; } 
            var customer = new Customer { Name = name, Email = email, Phone = phone, CreatedAt = DateTime.UtcNow };
            await _context.Customer.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer?> UpdateCustomer(int id, string newName, string newEmail, string newPhone )
        {
            Customer customer = await GetCustomer(id);
            if (customer != null)
            {
                customer.Name = newName ?? customer.Name;
                customer.Email = newEmail ?? customer.Email;
                customer.Phone = newPhone ?? customer.Phone;
                customer.UpdatedAT = DateTime.UtcNow;

                await _context.SaveChangesAsync();

                return customer;
            }
            return null;
        }

        public async Task<Customer?> DeleteCustomer(int id)
        {
            Customer customer = await GetCustomer(id);

            if (customer != null)
            {
                _context.Customer.Remove(customer);
                await _context.SaveChangesAsync();

                return customer;
            }

            return null;
        }





        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie?> GetMovie(int id)
        {
            return await _context.Movies.Include(m => m.Screenings).FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Movie?> CreateMovie(string title, string rating, string description, int runtimeMins)
        {
            if (title == "" || rating == null || description == ""|| runtimeMins==null) return null;
            var movie = new Movie { Title = title, Rating = rating, Description = description, RuntimeMins = runtimeMins, CreatedAt=DateTime.UtcNow };
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie?> UpdateMovie(int id, string newTitle, string newRating, string newDescription, int newRuntimeMins)
        {
            Movie movie = await GetMovie(id);
            if (movie != null)
            {
                movie.Title = newTitle ?? movie.Title;
                movie.Rating = newRating ?? movie.Rating;
                movie.Description = newDescription ?? movie.Description;
                movie.RuntimeMins = newRuntimeMins;
;
                movie.UpdatedAT = DateTime.UtcNow;

                await _context.SaveChangesAsync();

                return movie;
            }
            return null;
        }

        public async Task<Movie?> DeleteMovie(int id)
        {
            Movie movie = await GetMovie(id);

            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
                return movie;
            }

            return null;
        }


        public async Task<IEnumerable<Screenings>> GetScreenings(int movieID)
        {
            return await _context.Screenings.Where(s => s.MovieID == movieID).ToListAsync();
        }

        public async Task<Screenings?> GetScreening(int id)
        {
            return await _context.Screenings.Include(s=> s.Tickets).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Screenings?> CreateScreening(int movieID, int screenNumber, int capacity, DateTime StartsAt )
        {
            if (screenNumber == null || capacity == null || StartsAt == null) return null;
            var screening = new Screenings { ScreenNumber = screenNumber, Capacity = capacity, StartsAt = StartsAt, CreatedAt = DateTime.UtcNow };
            Movie? movie = await GetMovie(movieID);
            if (movie == null)
            {
                return null;
            }
            movie.Screenings.Add(screening);
            await _context.Screenings.AddAsync(screening);
            
            await _context.SaveChangesAsync();
            return screening;
        }




        public async Task<IEnumerable<Ticket>> GetTickets(int customerId, int screeningID)
        {
            return await _context.Tickets.Where(t => t.CustomerID == customerId).Where(t => t.ScreeningID == screeningID).ToListAsync();
        }


        public async Task<int> GetNumberOfAvailableSeats(int screeningID)
        {
            Screenings? screening = await GetScreening(screeningID);
            if (screening == null)
            {
                return 0;
            }

            if (screening.Tickets == null) return 0;
            int numSeatsAvailable = screening.Capacity;

            foreach (Ticket ticket in screening.Tickets)
            {
                numSeatsAvailable -= ticket.numSeats;
            }

            return numSeatsAvailable;
        }



        public async Task<Ticket?> BookTicket(int customerID, int screeningID, int numSeats)
        {
            if (customerID == null || screeningID == null || numSeats == null) return null;

            var ticket = new Ticket {numSeats = numSeats, CustomerID = customerID, ScreeningID=screeningID, CreatedAt = DateTime.UtcNow };
            Screenings? screening = await GetScreening(screeningID);
            if (screening == null)
            {
                return null;
            }

            screening.Tickets.Add(ticket);

            Customer? customer = await GetCustomer(customerID);
            if (customer == null)
            {
                return null;
            }
            customer.Tickets.Add(ticket);

            await _context.Tickets.AddAsync(ticket);

            await _context.SaveChangesAsync();
            return ticket;
        }
    }
}
