using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    namespace api_cinema_challenge.Data
    {
        public class Seeder
        {
            private List<string> _firstNames = new List<string>()
        {
            "Alice", "Bob", "Charlie", "Diana", "Eve",
            "Frank", "Grace", "Hank", "Ivy", "Jack"
        };

            private List<string> _lastNames = new List<string>()
        {
            "Smith", "Johnson", "Williams", "Jones", "Brown",
            "Davis", "Miller", "Wilson", "Moore", "Taylor"
        };

            private List<string> _movieTitles = new List<string>()
        {
            "The Great Adventure", "Romance in Paris", "Space Odyssey",
            "The Last Stand", "Comedy Central", "Mystery Mansion",
            "Fast Wheels", "Horror Nights", "Dreams of Tomorrow", "The Epic Quest"
        };

            private List<string> _ratings = new List<string>()
        {
            "G", "PG", "PG-13", "R", "NC-17"
        };

            private List<Customer> _customers = new List<Customer>();
            private List<Movie> _movies = new List<Movie>();
            private List<Screening> _screenings = new List<Screening>();

            public Seeder()
            {
                // Static date for CreatedAt and UpdatedAt
                DateTime staticDate = new DateTime(2023, 10, 1).ToUniversalTime();

                // Generate Customers
                for (int i = 1; i <= 50; i++)
                {
                    string firstName = _firstNames[(i - 1) % _firstNames.Count];
                    string lastName = _lastNames[(i - 1) % _lastNames.Count];

                    Customer customer = new Customer
                    {
                        Id = i,
                        Name = $"{firstName} {lastName}",
                        Email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com",
                        Phone = $"123-456-{i.ToString().PadLeft(4, '0')}", // Static phone number
                        CreatedAt = staticDate,
                        UpdatedAt = staticDate
                    };
                    _customers.Add(customer);
                }

                // Generate Movies
                for (int i = 1; i <= 10; i++)
                {
                    Movie movie = new Movie
                    {
                        Id = i,
                        Title = _movieTitles[i - 1],
                        Description = $"Description for {_movieTitles[i - 1]}",
                        Rating = _ratings[(i - 1) % _ratings.Count], // Static rating
                        RuntimeMins = 90 + (i * 10), // Static runtime
                        CreatedAt = staticDate,
                        UpdatedAt = staticDate
                    };
                    _movies.Add(movie);
                }

                // Generate Screenings
                for (int i = 1; i <= 30; i++)
                {
                    int movieId = _movies[(i - 1) % _movies.Count].Id;
                    Screening screening = new Screening
                    {
                        Id = i,
                        ScreenNumber = (i % 5) + 1, // Static screen number
                        Capacity = 100, // Static capacity
                        StartsAt = staticDate.AddDays(i).AddHours(10), // Static start time
                        MovieId = movieId,
                        CreatedAt = staticDate,
                        UpdatedAt = staticDate
                    };
                    _screenings.Add(screening);
                }
            }

            public List<Customer> Customers => _customers;
            public List<Movie> Movies => _movies;
            public List<Screening> Screenings => _screenings;
        }
    }
}
