using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;

        public Repository(CinemaContext db)
        {
            _db = db;
        }


        /// MOVIES
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.Include(a => a.Screenings).ToListAsync();
        }

        public async Task<Movie?> GetMovie(int MovieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            switch (preloadPolicy)
            {
                case PreloadPolicy.PreloadRelations:
                    return await _db.Movies.Include(a => a.Screenings).FirstOrDefaultAsync(s => s.Id == MovieId);
                case PreloadPolicy.DoNotPreloadRelations:
                    return await _db.Movies.FirstOrDefaultAsync(s => s.Id == MovieId);
                default:
                    return null;
            }
        }

        public async Task<Movie?> DeleteMovie(int MovieId, PreloadPolicy preloadPolicy = PreloadPolicy.PreloadRelations)
        {
            var mv = await _db.Movies.Include(a => a.Screenings).FirstOrDefaultAsync(s => s.Id == MovieId);


            if (mv == null) {
                return null;
            }

            List<Screening> scr = _db.Screenings.Where(x => x.MovieId == mv.Id).ToList();

            foreach (Screening sc in scr)
            {
                _db.Screenings.Remove(sc);
            }

            _db.Movies.Remove(mv);

            return mv;
                
        }

        public async Task<Movie?> CreateMovie(string title, string rating, string description, int runtimemins)
        {
            if (title == "" || rating == "" || description == "" ||  runtimemins <= 0) return null;

            var movie = new Movie { 
                Title = title, 
                Rating = rating,
                Description = description, 
                RuntimeMins = runtimemins,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime() };

            await _db.Movies.AddAsync(movie);
            
            return movie;
        }

        public async Task<Movie?> UpdateMovie(int MovieId, string title, string rating, string description, int runtimemins, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {

            var mv = await _db.Movies.Include(x => x.Screenings).FirstOrDefaultAsync(s => s.Id == MovieId);

            if (mv == null)
            {
                return null;
            }

            if (title !=  null) { mv.Title = title; }

            if (rating != null) {  mv.Rating = rating; }
            
            if (description != null ) {  mv.Description = description; }

            if (runtimemins >= 0) { mv.RuntimeMins = runtimemins; }
            
            mv.UpdatedAt = DateTime.Now.ToUniversalTime();

            return mv;

        }


        /// CUSTOMERS
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _db.Customers.ToListAsync();
        }

        public async Task<Customer?> GetCustomer(int CustomerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            switch (preloadPolicy)
            {
                case PreloadPolicy.PreloadRelations:
                    return await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);
                case PreloadPolicy.DoNotPreloadRelations:
                    return await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);
                default:
                    return null;
            }
        }

        public async Task<Customer?> DeleteCustomer(int CustomerId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var mv = await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);

            if (mv == null)
            {
                return null;
            }

            _db.Customers.Remove(mv);

            return mv;
        }

        public async Task<Customer?> CreateCustomer(string name, string email, string phone)
        {
            if (name == "" || email == "" || phone == "") return null;
            var customer = new Customer { Name = name, Email = email, Phone = phone, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt =  DateTime.Now.ToUniversalTime()  };
            await _db.Customers.AddAsync(customer);
            return customer;
        }

        public async Task<Customer?> UpdateCustomer(int CustomerId, string name, string email, string phone, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            var mv = await _db.Customers.FirstOrDefaultAsync(s => s.Id == CustomerId);

            if (mv == null)
            {
                return null;
            }

            if (name != null) { mv.Name = name; }

            if (email != null) { mv.Email = email; }

            if (phone != null) { mv.Phone = phone; }

            mv.UpdatedAt = DateTime.Now.ToUniversalTime();

            return mv;
        }


        /// SCREENINGS
        public async Task<IEnumerable<Screening>> GetScreenings(int id)
        {
            return await _db.Screenings.Where(x => x.MovieId == id).Include(a => a.Movie).ToListAsync();
        }


        public async Task<Screening?> CreateScreening(int screennumber, int capacity, DateTime datetime, int movieId)
        {
            if (screennumber <= 0 || capacity <= 0 ) return null;
            var screening = new Screening { 
                ScreenNumber = screennumber,
                Capacity = capacity,
                MovieId = movieId,
                StartsAt = datetime,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime()
                 };
            await _db.Screenings.AddAsync(screening);
            return screening;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
