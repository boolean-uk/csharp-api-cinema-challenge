using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        #region Properties
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Customer> _customers = new List<Customer>();

        public List<Movie> Movies { get => _movies; }
        public List<Screening> Screenings { get => _screenings; }
        public List<Customer> Customers { get => _customers; }
        #endregion

        public Seeder()
        {
            Movie newMovie = new Movie()
            {
                Id = 1,
                Title = "Dodgeball",
                Rating = "PG-13",
                Description = "The greatest movie ever made.",
                RuntimeMins = 126,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            _movies.Add(newMovie);

            Screening newScreening = new Screening()
            {
                Id = 1,
                ScreenNumber = 5,
                Capacity = 40,
                StartsAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                MovieId = 1,
            };
            _screenings.Add(newScreening);

            _customers.Add(new Customer()
            {
                Id = 1,
                Name = "Chris Wolstenholme",
                Email = "chris@muse.mu",
                Phone = "+44729388192",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                ScreeningId = 1,
            });
        }
    }
}
