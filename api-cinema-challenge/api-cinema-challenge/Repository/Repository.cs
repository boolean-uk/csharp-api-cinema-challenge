using api_cinema_challenge.Data;
using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screen;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        // Get all
        public IEnumerable<Customer> GetCustomers()
        {
            using (var db = new CinemaContext())
            {
                return db.customers.ToList();
            }
        }

        public IEnumerable<Screen> GetScreens()
        {
            using (var db = new CinemaContext())
            {
                return db.screens.ToList();
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            using (var db = new CinemaContext())
            {
                return db.movies.ToList();
            }
        }

        // Get one
        public Customer GetCustomer(int id)
        {
            Customer? customer = null;

            using (var db = new CinemaContext())
            {
                customer = db.customers.FirstOrDefault(c => c.Id == id);
            }

            return customer;
        }
        public Movie GetMovie(int id)
        {
            Movie? movie = null;

            using (var db = new CinemaContext())
            {
                movie = db.movies.FirstOrDefault(m => m.id == id);
            }

            return movie;
        }

        // Add one
        public bool AddCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                db.customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AddScreen(Screen screen)
        {
            using (var db =new CinemaContext())
            {
                db.screens.Add(screen);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool AddMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                db.movies.Add(movie);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Update one 
        public bool UpdateCustomer(int id, Customer customer)
        {
            using (var db = new CinemaContext())
            {

                if (customer != null)
                {
                    db.customers.Attach(customer);
                    db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        public bool UpdateMovie(int id, Movie movie)
        {
            using (var db = new CinemaContext())
            {

                if (movie != null)
                {
                    db.movies.Attach(movie);
                    db.Entry(movie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        // Delete one
        public bool DeleteCustomer(int id)
        {
            Customer? customer = null;

            using (var db = new CinemaContext())
            {
                var targetCustomer = db.customers.FirstOrDefault(c => c.Id == id);
                if (targetCustomer != null)
                {
                    db.Remove(targetCustomer);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteMovie(int id)
        {
            Movie? movie = null;

            using (var db = new CinemaContext())
            {
                var targetMovie = db.movies.FirstOrDefault(m => m.id == id);
                if (targetMovie != null)
                {
                    db.Remove(targetMovie);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

    }
}
