using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Roger Rogan",
                Email = "roger@rogan.com",
                Phone = "+44729389128",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Chris Wolstenholme",
                Email = "chris@muse.mu",
                Phone = "+44729388192",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Lisa Timber",
                Email = "lisa@timber.com",
                Phone = "+47123456789",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _customers.Add(customer1);
            _customers.Add(customer2);
            _customers.Add(customer3);

            Movie movie1 = new Movie()
            {
                Id = 1,
                Title = "Dodgeball",
                Rating = "PG-13",
                Description = "The greatest movie ever made.",
                RuntimeMins = 126,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            Movie movie2 = new Movie()
            {
                Id = 2,
                Title = "Forrest Gump",
                Rating = "PG-13",
                Description = "The story of a lifetime.",
                RuntimeMins = 142,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _movies.Add(movie1);
            _movies.Add(movie2);

            Screening screening1 = new Screening()
            {
                Id = 1,
                MovieId = 1,
                ScreenNumber = 2,
                Capacity = 40,
                StartsAt = DateTime.UtcNow.AddDays(2),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            Screening screening2 = new Screening()
            {
                Id = 2,
                MovieId = 2,
                ScreenNumber = 4,
                Capacity = 80,
                StartsAt = DateTime.UtcNow.AddDays(1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _screenings.Add(screening1);
            _screenings.Add(screening2);

            Ticket ticket1 = new Ticket()
            {
                Id = 1,
                NumSeats = 2,
                ScreeningId = 1,
                CustomerId = 1,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _tickets.Add(ticket1);

        }
        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
    }
}
