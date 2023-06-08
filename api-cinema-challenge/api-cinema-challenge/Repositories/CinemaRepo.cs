using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace api_cinema_challenge.Repositories
{
    public class CinemaRepo : ICinemaRepo
    {
        public Customer CreateCustomer(Customer customer)
        {
            using (var db = new CinemaContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return customer;
            }

        }

        public Movie CreateMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return movie;
            }
        }

        public Screening CreateScreening(Screening screen)
        {
            using (var db = new CinemaContext())
            {
                db.Screenings.Add(screen);
                db.SaveChanges();
                return screen;
            }
        }

        public Ticket CreateTicket(Ticket ticket)
        {
            using (var db = new CinemaContext())
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
                return ticket;
            }
        }

        public Customer DeleteCustomer(int id)
        {
            using (var db = new CinemaContext())
            {
                var deleteCusomer = db.Customers.FirstOrDefault(c => c.Id == id);
                if (deleteCusomer != null)
                {
                    db.Customers.Remove(deleteCusomer);
                    db.SaveChanges() ;
                    return deleteCusomer;

                }
                return null;
            }
        }

        public Movie DeleteMovie(int id)
        {
            using (var db = new CinemaContext())
            {
                var deleteMovie = db.Movies.FirstOrDefault(c => c.Id == id);
                if (deleteMovie != null)
                {
                    db.Movies.Remove(deleteMovie);
                    db.SaveChanges();
                    return deleteMovie;

                }
                return null;
            }
        }

        public Screening DeleteScreening(int id)
        {
            using (var db = new CinemaContext())
            {
                var deletescreen = db.Screenings.FirstOrDefault(c => c.Id == id);
                if (deletescreen != null)
                {
                    db.Screenings.Remove(deletescreen);
                    db.SaveChanges();
                    return deletescreen;

                }
                return null;
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            using(var db = new CinemaContext())
            {
                return db.Customers.Include(x=> x.Ticket).ThenInclude(x=>x.screening).ThenInclude(x => x.movie).ToList();
            }
        }

        public IEnumerable<Movie> GetallMovies()
        {
            using (var db = new CinemaContext())
            {
                return db.Movies.ToList();
            }
        }

        public IEnumerable<Screening> GetallScreenings()
        {
            using (var db = new CinemaContext())
            {
                foreach (var c in db.Screenings)
                {
                    string date = c.startsAt.ToString("yyyy-MM-dd HH:mm:ss");
                    c.startsAt = DateTime.Parse(date);

                }
                return db.Screenings.Include(e=> e.movie).ToList();
            }

        }

        public IEnumerable<Ticket> GetallTicket()
        {
            using (var db = new CinemaContext())
            {
                return db.Tickets.Include(t => t.screening).ThenInclude(e => e.movie).ToList();
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (var db = new CinemaContext())
            {
                var customer = db.Customers.Include(x => x.Ticket).ThenInclude(x => x.screening).ThenInclude(x => x.movie).FirstOrDefault(c => c.Id == id);
                if (customer != null)
                {
                    
                    return customer;

                }
                return null;
            }
        }

        public Movie GetMovieById(int id)
        {
            using (var db = new CinemaContext())
            {
                var movie = db.Movies.FirstOrDefault(c => c.Id == id);
                if (movie != null)
                {

                    return movie;

                }
                return null;
            }
        }

        public Screening GetScreeningById(int id)
        {
            using (var db = new CinemaContext())
            {
                var screen = db.Screenings.Include(x=>x.movie).FirstOrDefault(c => c.Id == id);
                if (screen != null)
                {

                    return screen;

                }
                return null;
            }
        }

        public Customer UpdateCustomer(Customer customer, int id)
        {
            using (var db = new CinemaContext())
            {
                var updatedCustomer = db.Customers.Include(x => x.Ticket).ThenInclude(x => x.screening).ThenInclude(x => x.movie).FirstOrDefault(c => c.Id == id);
                if (updatedCustomer != null)
                {
                    updatedCustomer = customer;
                   // updatedCustomer.Id = id;
                   // updatedCustomer.Name = customer.Name;
                   // updatedCustomer.Email = customer.Email;
                   // updatedCustomer.Phone = customer.Phone;
                   // updatedCustomer.UpdatedDate = DateTime.UtcNow;
                    db.SaveChanges();
                    return updatedCustomer;

                }
                return null;
            }
        }

        public Movie UpdateMovie(Movie movie, int id)
        {
            using (var db = new CinemaContext())
            {
                var updatedMovie = db.Movies.FirstOrDefault(c => c.Id == id);
                if (updatedMovie != null)
                {
                    updatedMovie = movie;
                    //updatedMovie.Id = id;
                    //updatedMovie.runtime = movie.runtime;
                    //updatedMovie.description = movie.description;
                    //updatedMovie.tittle = movie.tittle;
                    //updatedMovie.UpdatedAt = DateTime.UtcNow;
                   // updatedMovie.rating = movie.rating;
                    db.SaveChanges();
                    return updatedMovie;

                }
                return null;
            }

        }

        public Screening UpdateScreening(Screening screen, int id)
        {
            using (var db = new CinemaContext())
            {
                var updatedScreen = db.Screenings.Include(x=> x.movie).FirstOrDefault(c => c.Id == id);
                if (updatedScreen != null)
                {
                    updatedScreen = screen;
                   // updatedScreen.Id = id;
                   // updatedScreen.capacity = screen.capacity;

                   // updatedScreen.screenNumber = screen.screenNumber;
                   //updatedScreen.startsAt = screen.startsAt;
                   // updatedScreen.UpdatedAt = DateTime.UtcNow;
                    
                    db.SaveChanges();
                    return updatedScreen;

                }
                return null;
            }
        }
    }
}
