using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        public List<Screening> screeningsWithMovie = new List<Screening>();

        public Customer AddCustomer(Customer customer)
        {
            using(var db = new CinemaContext())
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
                db.Movies.Add(movie);
                db.SaveChanges();
                return movie;
            }
        }

        public Screening AddScreening(Screening screening, int movieid)
        {
            using (var db = new CinemaContext())
            {
                db.Screenings.Add(screening);
                db.SaveChanges();
                return screening;
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

        public Screening DeleteScreening(int id)
        {
            using (var db = new CinemaContext())
            {
                var screening = db.Screenings.SingleOrDefault(z  => z.Id == id);
                db.Screenings.Remove(screening);
                db.SaveChanges();
                return screening;
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
                return db.Movies.ToList();
            }
        }

        public IEnumerable<Screening> GetScreenings()
        {
            using (var db = new CinemaContext())
            {
                return db.Screenings.Include(i => i.MovieId).ToList();
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

        public Screening UpdateScreening(Screening screening)
        {
            using (var db = new CinemaContext())
            {
                screening.UpdatedAt = DateTime.UtcNow;
                db.Screenings.Update(screening);
                db.SaveChanges();
                return screening;
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

        public IEnumerable<Screening> GetScreeningsbyMovie(int movieid)
        {
            screeningsWithMovie.Clear();

            using(var db = new CinemaContext())
            {

                foreach (var screening in db.Screenings)
                {
                    if (screening.MovieId == movieid)
                        screeningsWithMovie.Add(screening);
                }
                return screeningsWithMovie; 
            }
        }
    }
}
