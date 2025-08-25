using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Enums;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<string> _firstNames = new List<string>()
        {
            "Audrey",
            "Donald",
            "Elvis",
            "Barack",
            "Oprah",
            "Jimi",
            "Mick",
            "Kate",
            "Charles",
            "Kate"
        };

        private List<string> _lastNames = new List<string>()
        {
            "Hepburn",
            "Trump",
            "Presley",
            "Obama",
            "Winfrey",
            "Hendrix",
            "Jagger",
            "Winslet",
            "Windsor",
            "Middleton"
        };

        private List<string> _domains = new List<string>()
        {
            "gmail.com",
            "google.com",
            "hotmail.com",
            "something.com",
            "mcdonalds.com",
            "nasa.org.us",
            "gov.us",
            "gov.gr",
            "gov.nl",
            "gov.ru"
        };

        private List<string> _movieTitles = new List<string>()
        {
            "The Lost Kingdom", "Space Odyssey", "Dreamcatcher",
            "Ocean Deep", "Hidden Truths", "Shadows Rising",
            "Eternal Flame", "The Great Escape", "Parallel Worlds", "Infinite Loop"
        };

        private List<string> _descriptions = new List<string>()
        {
            "An epic adventure across unknown lands.",
            "A thrilling journey through space and time.",
            "A heartwarming story of friendship and courage.",
            "A suspenseful drama filled with mystery.",
            "A hilarious comedy for the whole family.",
            "A dark tale of betrayal and survival."
        };

        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {
            Random random = new Random();

            for (int x = 1; x < 50; x++)
            {
                var first = _firstNames[random.Next(_firstNames.Count)];
                var last = _lastNames[random.Next(_lastNames.Count)];
                var domain = _domains[random.Next(_domains.Count)];

                Customer customer = new Customer
                {
                    Id = x,
                    Name = $"{first} {last}",
                    Email = $"{first}{last}@{domain}",
                    Phone = $"06{random.Next(1000, 9999)}{random.Next(1000, 9999)}"
                };
                _customers.Add(customer);
            }

            for (int y = 1; y < 50; y++)
            {
                Movie movie = new Movie
                {
                    Id = y,
                    Title = _movieTitles[random.Next(_movieTitles.Count)],
                    Rating = (MovieRating)random.Next(Enum.GetNames(typeof(MovieRating)).Length),
                    Description = _descriptions[random.Next(_descriptions.Count)],
                    RuntimeMins = random.Next(90, 180)
                };
                _movies.Add(movie);
            }

            foreach (var movie in _movies)
            {
                int screeningsAmount = random.Next(1, 5);
                for (int z = 0; z < screeningsAmount; z++)
                {
                    Screening screening = new Screening
                    {
                        Id = z,
                        MovieId = movie.Id,
                        ScreenNumber = random.Next(1, 5),
                        Capacity = random.Next(20, 60),
                        startsAt = DateTime.UtcNow.AddDays(random.Next(1, 15))
                    };
                }
            }

            foreach (var screening in _screenings)
            {
                int ticketsAmount = random.Next(1, 60);
                for (int a = 0; a < ticketsAmount; a++)
                {
                    var customer = _customers[random.Next(_customers.Count)];

                    Ticket ticket = new Ticket
                    {
                        Id = a,
                        NumSeats = random.Next(1, 5),
                        ScreeningId = screening.Id,
                        CustomerId = customer.Id
                    };
                    _tickets.Add(ticket);
                }
            }
        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
    }
}
