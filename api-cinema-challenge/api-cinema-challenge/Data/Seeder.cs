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
            private List<Ticket> _tickets = new List<Ticket>();

            public Seeder()
            {
                DateTime staticDate = new DateTime(2023, 10, 1).ToUniversalTime();

                for (int i = 1; i <= 50; i++)
                {
                    string firstName = _firstNames[(i - 1) % _firstNames.Count];
                    string lastName = _lastNames[(i - 1) % _lastNames.Count];

                    Customer customer = new Customer
                    {
                        Id = i,
                        Name = $"{firstName} {lastName}",
                        Email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com",
                        Phone = $"123-456-{i.ToString().PadLeft(4, '0')}", 
                        CreatedAt = staticDate,
                        UpdatedAt = staticDate
                    };
                    _customers.Add(customer);
                }

                for (int i = 1; i <= 10; i++)
                {
                    Movie movie = new Movie
                    {
                        Id = i,
                        Title = _movieTitles[i - 1],
                        Description = $"Description for {_movieTitles[i - 1]}",
                        Rating = _ratings[(i - 1) % _ratings.Count], 
                        RuntimeMins = 90 + (i * 10), 
                        CreatedAt = staticDate,
                        UpdatedAt = staticDate
                    };
                    _movies.Add(movie);
                }

                for (int i = 1; i <= 28; i++)
                {
                    int movieId = _movies[(i - 1) % _movies.Count].Id;
                    Screening screening = new Screening
                    {
                        Id = i,
                        ScreenNumber = (i % 5) + 1, 
                        Capacity = 100, 
                        StartsAt = staticDate.AddDays(i).AddHours(10), 
                        MovieId = movieId,
                        CreatedAt = staticDate,
                        UpdatedAt = staticDate
                    };
                    _screenings.Add(screening);
                }

                for (int i = 1; i <= 100; i++) 
                {
                    int customerId = _customers[(i - 1) % _customers.Count].Id;
                    int screeningId = _screenings[(i - 1) % _screenings.Count].Id;
                    Ticket ticket = new Ticket
                    {
                        Id = i,
                        NumSeats = (i % 5) + 1, 
                        CreatedAt = staticDate,
                        UpdatedAt = staticDate,
                        CustomerId = customerId,
                        ScreeningId = screeningId,
                    };
                    _tickets.Add(ticket);
                }
            }

            public List<Customer> Customers => _customers;
            public List<Movie> Movies => _movies;
            public List<Screening> Screenings => _screenings;
            public List<Ticket> Tickets => _tickets;
        }
    }
}
