using api_cinema_challenge.Context;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        public bool AddCustomer(Customers customer)
        {
            using(var db = new CinemaContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddMovie(Movies movie)
        {
            using(var db = new CinemaContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddScreening(Screenings screenings)
        {
            using( var db = new CinemaContext())
            {
                db.Screenings.Add(screenings);
                db.SaveChanges();
                return true;
            }
        }

        public bool AddTicket(Tickets tickets)
        {
            using(var db = new CinemaContext())
            {
                db.Tickets.Add(tickets);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteCustomer(int id)
        {
            using (var db = new CinemaContext())
            {
                var customer = db.Customers.FirstOrDefault(x => x.Id == id);
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteMovie(int id)
        {
            using (var db = new CinemaContext())
            {
                var movie = db.Movies.FirstOrDefault(x => x.Id == id);
                if (movie != null)
                {
                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<Customers> GetCustomers()
        {
            using(var db = new CinemaContext())
            {
                return db.Customers.ToList();
            }
        }

        public IEnumerable<Movies> GetMovies()
        {
            using(var db = new CinemaContext())
            {
                return db.Movies.ToList();
            }
        }

        public IEnumerable<Screenings> GetScreenings()
        {
            using(var db = new CinemaContext())
            {
                return db.Screenings.ToList();
            }
        }

        public IEnumerable<Tickets> GetTickets()
        {
            using (var db = new CinemaContext())
            {
                return db.Tickets.ToList();
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            using (var db = new CinemaContext())
            {
                db.Customers.Update(customer);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateMovie(Movies movies)
        {
            using ( var db = new CinemaContext())
            {
                db.Movies.Update(movies);
                db.SaveChanges();
                return true;
            }
        }
    }
}
