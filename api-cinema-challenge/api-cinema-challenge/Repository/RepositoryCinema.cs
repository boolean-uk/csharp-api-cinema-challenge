using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class RepositoryCinema : iRepositoryCinema
    {
        public RepositoryCinema() { }

        public Customer AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                customer.CreatedAt = DateTime.UtcNow;
                customer.UpdatedAt = DateTime.UtcNow;
                db.Customers.Add(customer);
                db.SaveChanges();
                return customer;
            }
        }

        public Movie AddMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                movie.CreatedAt = DateTime.UtcNow;
                movie.UpdatedAt = DateTime.UtcNow;
                db.Movies.Add(movie);
                db.SaveChanges();
                return movie;
            }
        }

        public Screening AddScreening(Screening screening)
        {
            using (var db = new CinemaContext())
            {
                screening.CreatedAt = DateTime.UtcNow;
                screening.UpdatedAt = DateTime.UtcNow;
                db.Movies.Find(screening.MovieId).screenings.Add(screening);
                db.Screenings.Add(screening);
                db.SaveChanges();
                return screening;
            }
        }

        public Ticket AddTicket(Ticket ticket)
        {
            using (var db = new CinemaContext())
            {
                ticket.CreatedAt = DateTime.UtcNow;
                ticket.UpdatedAt = DateTime.UtcNow;
                db.Tickets.Add(ticket);
                db.SaveChanges();
                return ticket;
            }
        }

        public Customer DeleteCustomer(int id)
        {
            using (var db = new CinemaContext())
            {
                var customer = db.Customers.SingleOrDefault(x => x.Id == id);
                db.Customers.Remove(customer);
                db.SaveChanges();
                return customer;
            }
        }

        public Movie DeleteMovie(int id)
        {
            using (var db = new CinemaContext())
            {
                var movie = db.Movies.SingleOrDefault(y => y.Id == id);
                db.Movies.Remove(movie);
                db.SaveChanges();
                return movie;
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            using (var db = new CinemaContext())
            {
                return db.Customers.ToList();
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            using (var db = new CinemaContext())
            {
                return db.Movies.Include(a => a.screenings).ToList();
            }
        }

        public IEnumerable<Screening> GetScreenings(int id)
        {
            using (var db = new CinemaContext())
            {
                List<Screening> list = new List<Screening>();
                foreach(Screening screening in db.Screenings)
                {
                    if (screening.MovieId == id)
                    {
                        list.Add(screening);
                    }
                }
                return list;
            }
        }

        public IEnumerable<Ticket> GetTickets()
        {
            using (var db = new CinemaContext())
            {
                return db.Tickets.ToList();
            }
        }

        public Customer UpdateCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                customer.UpdatedAt = DateTime.UtcNow;
                db.Customers.Update(customer);
                db.SaveChanges();
                return customer;
            }
        }

        public Movie UpdateMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                movie.UpdatedAt = DateTime.UtcNow;
                db.Movies.Update(movie);
                db.SaveChanges();
                return movie;
            }
        }
    }
}
