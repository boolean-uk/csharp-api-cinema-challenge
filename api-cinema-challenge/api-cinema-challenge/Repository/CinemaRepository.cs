using api_cinema_challenge.Context;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly CinemaContext _context;
        public CinemaRepository(CinemaContext context)
        {
            _context = context;
        }
        public bool AddCustomer(Customers customer)
        {
            
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return true;
            
        }

        public Movies AddMovie(Movies movie)
        {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return movie;
        }

        public bool AddScreening(Screenings screenings)
        {
                _context.Screenings.Add(screenings);
                _context.SaveChanges();
                return true;
        }

        public bool AddTicket(Tickets tickets)
        {
                _context.Tickets.Add(tickets);
                _context.SaveChanges();
                return true;
        }

        public bool DeleteCustomer(int id)
        {
                var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                    return true;
                }
                return false;
        }

        public bool DeleteMovie(int id)
        {
                var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
                if (movie != null)
                {
                    _context.Movies.Remove(movie);
                    _context.SaveChanges();
                    return true;
                }
            return false;
        }

        public IEnumerable<Customers> GetCustomers()
        {
                return _context.Customers.ToList();
        }

        public IEnumerable<Movies> GetMovies()
        {
                return _context.Movies.Include(x => x.Screenings).ToList();
        }

        public IEnumerable<Screenings> GetScreenings()
        {
                return _context.Screenings.ToList();
        }

        public IEnumerable<Tickets> GetTickets()
        {
                return _context.Tickets.ToList();
        }

        public bool UpdateCustomer(Customers customer)
        {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return true;
        }

        public bool UpdateMovie(Movies movies)
        {
                _context.Movies.Update(movies);
                _context.SaveChanges();
                return true;
        }
    }
}
