using api_cinema_challenge.DataContext;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Screening;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    return db.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Customer GetCustomer(int id)
        {
            using (var db = new CinemaContext())
            {
                Customer result = db.Customers.FirstOrDefault(c => c.Id == id);
                return result;
            }
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    db.Customers.Add(customer);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    db.Customers.Update(customer);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    var customerToDelete = db.Customers.FirstOrDefault(c => c.Id == id);
                    if (customerToDelete != null)
                    {
                        db.Customers.Remove(customerToDelete);
                        int affectedRows = db.SaveChanges();
                        if (affectedRows > 0)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    return db.Movies.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Movie GetMovie(int id)
        {
            using (var db = new CinemaContext())
            {
                Movie result = db.Movies.FirstOrDefault(m => m.Id == id);
                return result;
            }
        }

        public bool AddMovie(Movie movie)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    db.Movies.Add(movie);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateMovie(Movie movie)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    db.Movies.Update(movie);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteMovie(int id)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    var movieToDelete = db.Movies.FirstOrDefault(m => m.Id == id);
                    if (movieToDelete != null)
                    {
                        db.Movies.Remove(movieToDelete);
                        int affectedRows = db.SaveChanges();
                        if (affectedRows > 0)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Screening> GetAllScreenings()
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    return db.Screenings.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool AddScreening(Screening screening)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    db.Screenings.Add(screening);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    return db.Tickets.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool BookTicket(Ticket ticket)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    db.Tickets.Add(ticket);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
