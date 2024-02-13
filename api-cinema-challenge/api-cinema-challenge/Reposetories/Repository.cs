using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.DTO_Ticket;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace api_cinema_challenge.Reposetories
{
    public class Repository : IRepository
    {
        private CinemaContext _cinemaContext;
        public Repository(CinemaContext db)
        {
            _cinemaContext = db;
        }
        public async Task<Customer> CreateCustomer(string name, string email, string phoneNumber)
        {
            Customer customer = new Customer();
            customer.name = name;
            customer.email = email;
            customer.phone = phoneNumber;
            customer.createdAt = DateTime.Now.ToUniversalTime();
            customer.updatedAt = DateTime.Now.ToUniversalTime();
            _cinemaContext.Customers.Add(customer);
            _cinemaContext.SaveChanges();
            return customer;
        }


        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            var customers = await _cinemaContext.Customers.ToListAsync();
            _cinemaContext.SaveChanges();

            return customers;
        }

        public async Task<Customer?> UpdateCustomer(int id, string name, string email, string phoneNumber)
        {
            var customer = await _cinemaContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }
            customer.name = name;
            customer.email = email;
            customer.phone = phoneNumber;
            customer.updatedAt = DateTime.Now.ToUniversalTime();

            
            _cinemaContext.SaveChanges();
            return customer;

        }
        public async Task<Customer?> DeleteCustomer(int id)
        {
            var customer = await _cinemaContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }

            var result = customer;

            _cinemaContext.Customers.Remove(customer);

            _cinemaContext.SaveChanges();

            return result;

        }

        public async Task<Movie> CreateMovie(string title, string rating, string description, int runtimeMins)
        {
            Movie movie = new Movie();
            movie.title = title;
            movie.rating = rating;
            movie.Description = description;
            movie.runtimeMins = runtimeMins;
            movie.createdAt = DateTime.Now.ToUniversalTime();
            movie.updatedAt = DateTime.Now.ToUniversalTime();
            _cinemaContext.Movies.Add(movie);
            _cinemaContext.SaveChanges();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = await _cinemaContext.Movies.ToListAsync();
            _cinemaContext.SaveChanges();

            return movies;
        }

        public async Task<Movie?> UpdateMovie(int id, string title, string rating, string description, int runtimeMins)
        {
            var movie = await _cinemaContext.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }
            movie.title = title;
            movie.rating = rating;
            movie.Description = description;
            movie.runtimeMins = runtimeMins;
            movie.updatedAt = DateTime.Now.ToUniversalTime();

            _cinemaContext.SaveChanges();
            return movie;
        }

        public async Task<Movie?> DeleteMovie(int id)
        {
            var movie = await _cinemaContext.Movies.FindAsync(id);
            if (movie == null)
            {
                return null;
            }

            var result = movie;

            _cinemaContext.Movies.Remove(movie);

            _cinemaContext.SaveChanges();

            return result;
        }

        public async Task<Screening> CreateScreening(int screenNumber, int capasity, DateTime startsAt, int movieid)
        {
           
            Screening screening = new Screening();
            screening.movieId = movieid;
            screening.screenNumber = screenNumber;
            screening.capacity = capasity;
            screening.remainingSeats = capasity;
            screening.startsAt = startsAt.ToUniversalTime();
            screening.createdAt = DateTime.Now.ToUniversalTime();
            screening.updatedAt = DateTime.Now.ToUniversalTime();
            _cinemaContext.Screenings.Add(screening);
            _cinemaContext.SaveChanges();
            return screening;
        }

        public async Task<IEnumerable<Screening?>> GetScreenings(int movieId)
        {
            var screenings = await _cinemaContext.Screenings.ToListAsync();
            List<Screening> result = new List<Screening>(); 
            foreach (var screening in screenings)
            {
                if(screening.movieId == movieId)
                {
                    result.Add(screening);
                }
                
            }

            _cinemaContext.SaveChanges();

            if (result.Count > 0)
            {
                return result;
            }
            else
            {
                return null;
            }
            

            

        }

        public async Task<Ticket?> BookATicket(int customerId, int screeningId, int numSeats)
        {
            //check if id is valid
            var screening = await _cinemaContext.Screenings.FindAsync(screeningId);
            if (screening == null)
            {
                return null;
            }

            //check if there are enough seats for the booked ticket.
            if(numSeats > screening.remainingSeats)
            {
                //should send some type of feedback to endpoints to trigger badrequest about the seats
            }

            //create new ticket 
            var ticket = new Ticket();
            ticket.customerId = customerId;
            ticket.screeningId = screeningId;
            ticket.numbSeats = numSeats;

            _cinemaContext.Tickets.Add(ticket);
            _cinemaContext.SaveChanges();
            return ticket;


        }

        public async Task<IEnumerable<Ticket?>> GetAllBookedTickets()
        {
            var tickets = await _cinemaContext.Tickets.ToListAsync();

            return tickets;
        }

        public async Task<IEnumerable<Ticket>?> GetAllCustomersTicketsPerScreaning(int customerId, int screeningId)
        {
            var tickets = await _cinemaContext.Tickets.Where(c => c.customerId == customerId && c.screeningId == screeningId).ToListAsync();
            if (tickets == null)
            { return null; }
            else
            {
                return tickets;
            }
            


        }
    }
}
