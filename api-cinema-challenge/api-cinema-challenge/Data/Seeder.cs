using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class seeder
    {
        private List<string> _firstnames = new List<string>()
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
        private List<string> _lastnames = new List<string>()
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
        private List<string> _domain = new List<string>()
        {
            "bbc.co.uk",
            "google.com",
            "theworld.ca",
            "something.com",
            "tesla.com",
            "nasa.org.us",
            "gov.us",
            "gov.gr",
            "gov.nl",
            "gov.ru"
        };
        private List<string> _titles = new List<string>()
        {
            "The Orange Cars",
            "Two Purple Flowers",
            "Several",
            "Fifteen Transparent Planets",
            "A bunch of Green Men",
            "An army of Zombies",
            "A herd of Microscopic Flowers"


        };
        private List<string> _ratings = new List<string>()
        {
            "PG-13",
            "PG",
            "R",
            "NC-17"
        };
        private List<string> _descriptions = new List<string>()
        {
            "Very scary",
            "Boooring",
            "Lorem ipsum test ummmm",
            "Who what where when"
        };

        private List<int> _runtimes = new List<int>()
        {
            122,
            60,
            86,
            190,
            135
        };

        private List<string> _phoneNumbers = new List<string>()
        {
            "61428868",
            "67137459",
            "59943377",
            "20778913",
            "97149314",
            "31878797",
            "44348162",
            "60245515"
        };             


        private List<Movie> _movies = new List<Movie>();
        private List<Customer> _customers = new List<Customer>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();
        
        public seeder()
        {
            Random movieRand = new Random();
            Random customerRand = new Random();
            var random = new Random();

            for (int i = 1; i < 11; i++)
            {
                Movie movie = new Movie();
                movie.Id = i;
                movie.Title = _titles[movieRand.Next(_titles.Count)];
                movie.Rating = _ratings[movieRand.Next(_ratings.Count)];
                movie.Runtime = _runtimes[movieRand.Next(_runtimes.Count)];
                movie.Description = _descriptions[movieRand.Next(_descriptions.Count)];
                movie.CreatedAt = DateTime.UtcNow;
                movie.UpdatedAt = DateTime.UtcNow;
                _movies.Add(movie);
            }

            for (int j = 1; j < 11 ; j++)
            {
                Customer customer = new Customer();
                customer.Id = j;
                customer.Name = $"{_firstnames[customerRand.Next(_firstnames.Count)]} {_lastnames[customerRand.Next(_firstnames.Count)]}";
                customer.Email = $"{customer.Name}@{_domain[customerRand.Next(_domain.Count)]}";
                customer.PhoneNumber = _phoneNumbers[customerRand.Next(_phoneNumbers.Count)];
                customer.CreatedAt = DateTime.UtcNow;
                customer.UpdatedAt = DateTime.UtcNow;
                _customers.Add(customer);
            }

            for (int x = 1; x < 20 ; x++)
            {
                Screening screening = new Screening();
                screening.Id = x;
                screening.ScreenNumber = random.Next(1,11);
                screening.Capacity = random.Next(19,100);
                screening.startsAt = DateTime.UtcNow.AddDays(random.Next(1, 31)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60));
                screening.CreatedAt = DateTime.UtcNow;
                screening.UpdatedAt = DateTime.UtcNow;
                screening.MovieId = random.Next(1, _movies.Count);
                _screenings.Add(screening);
            }

            for (int y = 1; y < 20; y++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = y;
                ticket.SeatNumber = random.Next(1, 50);
                ticket.CreatedAt = DateTime.UtcNow;
                ticket.UpdatedAt = DateTime.UtcNow;
                ticket.ScreeningId = random.Next(1, _screenings.Count);
                ticket.CustomerID = random.Next(1, _customers.Count);
                _tickets.Add(ticket);

            }

        }

        public List<Movie> Movies { get { return _movies; } }
        public List<Customer> Customers { get { return _customers; } }
        public List<Screening> Screenings { get {  return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
    }
}
