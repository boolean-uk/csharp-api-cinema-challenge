using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
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
        private List<string> _firstword = new List<string>()
        {
            "The",
            "Two",
            "Several",
            "Fifteen",
            "A bunch of",
            "An army of",
            "A herd of"


        };
        private List<string> _secondword = new List<string>()
        {
            "Orange",
            "Purple",
            "Large",
            "Microscopic",
            "Green",
            "Transparent",
            "Rose Smelling",
            "Bitter"
        };
        private List<string> _thirdword = new List<string>()
        {
            "Buildings",
            "Cars",
            "Planets",
            "Houses",
            "Flowers",
            "Leopards"
        };

        private List<string> _numbers = new List<string>()
        {
            "+46987654321",
            "+46123212321",
            "+46363633636",
            "+46888888888",
            "+46123456789"
        };

        private List<string> _ratings = new List<string>()
        {   
            "NC-17",
            "R",
            "PG-13",
            "PG-7",
            "PG-3"
        };

        private List<Customer> _customers = new List<Customer>();
        
        private List<Movie> _movies = new List<Movie>();
        
        private List<Screening> _screening = new List<Screening>();

        private List<Ticket> _tickets = new List<Ticket>();
        public Seeder()
        {
            Random customerRandom = new Random();
            Random movieRandom = new Random();
            Random screeningRandom = new Random();
            Random ticketRandom = new Random();

            for (int x = 1; x < 5; x++)
            {
                Customer customer = new Customer();
                customer.id = x;
                string firstName = _firstnames[customerRandom.Next(_firstnames.Count)];
                string lastName = _lastnames[customerRandom.Next(_lastnames.Count)];
                customer.name = new string($"{firstName} {lastName}");
                customer.email = new string($"{firstName}{lastName}@{_domain[customerRandom.Next(_domain.Count)]}".ToLower());
                customer.phone = new string($"{_numbers[customerRandom.Next(_numbers.Count)]}");
                customer.createdAt = DateTime.Today.ToUniversalTime();
                customer.updatedAt = DateTime.Today.ToUniversalTime();
                _customers.Add(customer);
            }

            for (int x = 1;x < 5; x++)
            {
                Movie movie = new Movie();
                movie.id = x;
                movie.title = new string($"{_firstword[movieRandom.Next(_firstword.Count)]} {_secondword[movieRandom.Next(_secondword.Count)]} {_thirdword[movieRandom.Next(_thirdword.Count)]}");
                movie.Description = new string($"{_firstword[movieRandom.Next(_firstword.Count)]} {_secondword[movieRandom.Next(_secondword.Count)]} {_thirdword[movieRandom.Next(_thirdword.Count)]}");
                movie.rating = _ratings[movieRandom.Next(_ratings.Count)];                
                movie.runtimeMins = x * 15;
                movie.createdAt = DateTime.Today.ToUniversalTime();
                movie.updatedAt = DateTime.Today.ToUniversalTime();
                
                _movies.Add(movie);
            }

            for (int x = 1; x<5; x++)
            {
                Screening screening = new Screening();
                screening.id = x;
                screening.screenNumber = (x % 2) + 1;
                screening.capacity = 40;
                screening.movieId = screeningRandom.Next(_movies.Count);
                screening.startsAt = DateTime.Today.ToUniversalTime();
                screening.createdAt = DateTime.Today.ToUniversalTime();
                screening.updatedAt = DateTime.Today.ToUniversalTime();

                _screening.Add( screening );
            }

            for(int x = 1; x<4; x++)
            {
                Ticket ticket = new Ticket();
                ticket.id = x;
                ticket.customerId = ticketRandom.Next(_customers.Count);
                ticket.screeningId = ticketRandom.Next(_screening.Count);
                ticket.numbSeats = x * 2;
                ticket.createdAt = DateTime.Today.ToUniversalTime();
                ticket.updatedAt = DateTime.Today.ToUniversalTime();    
            }

        }

        public List<Movie> movies { get {  return _movies; } }  
        public List<Customer> customers { get { return _customers; } }
        public List<Screening> screenings { get { return _screening; } }  
        public List<Ticket> tickets { get { return _tickets; } }

        
    }
}
