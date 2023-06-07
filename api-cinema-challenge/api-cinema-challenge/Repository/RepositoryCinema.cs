using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class RepositoryCinema : iRepositoryCinema
    {
        public RepositoryCinema() { }

        public Customer AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                customer.CreatedAt = DateTime.Now;
                customer.UpdatedAt = DateTime.Now;
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

        public Screening AddScreening(Screening screening)
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

        public Customer UpdateCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                db.Customers.Update(customer);
                db.SaveChanges();
                return customer;
            }
        }

        public Movie UpdateMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                db.Movies.Update(movie);
                db.SaveChanges();
                return movie;
            }
        }
    }
}
