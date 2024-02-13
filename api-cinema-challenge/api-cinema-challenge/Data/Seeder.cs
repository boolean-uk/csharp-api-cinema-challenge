using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new();
        private List<Movie> _movies = new();
        private List<Screening> _screenings = new();
        private List<Ticket> _tickets = new();


        //random value strings generated with chatgpt:
        private List<string> _firstnames = new()
        {
            "John",
            "Jane",
            "Michael",
            "Emily",
            "William",
            "Sophia",
            "James",
            "Olivia",
            "Robert",
            "Emma"
        };

        private List<string> _lastnames = new List<string>
        {
            "Smith",
            "Johnson",
            "Williams",
            "Jones",
            "Brown",
            "Davis",
            "Miller",
            "Wilson",
            "Moore",
            "Taylor"
        };

        private List<string> _domains = new()
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

        private List<string> _movieNamePrefixes = new List<string>
        {
            "The ",
            "Return of ",
            "Journey to ",
            "Rise of ",
            "Revenge of ",
            "Escape from ",
            "Adventures in ",
            "Quest for ",
            "Invasion of ",
            "Attack of "
        };

        private List<string> _movieNameAdjectives = new List<string>
        {
            "Brave ",
            "Eternal ",
            "Mystic ",
            "Forgotten ",
            "Hidden ",
            "Lost ",
            "Magical ",
            "Forbidden ",
            "Enchanted ",
            "Legendary "
        };

        private List<string> _movieNameNouns = new List<string>
        {
            "Dragon",
            "Hero",
            "Sorcerer",
            "Kingdom",
            "Empire",
            "Crystal",
            "Guardian",
            "Legend",
            "Treasure",
            "Prophecy"
        };

        private List<string> _rating = new List<string>
        {
            "E",
            "T",
            "M"
        };


        static Random numRandom = new Random();
        private string generatePhoneNumber()
        { 
            return numRandom.Next(10000000, 100000000).ToString();
        }

        Random random = new();

        public Seeder() 
        { 
            for (int i = 1; i <= 10 ; i++)
            {
                Customer customer = new();
                customer.Id = i;
                string firstname = _firstnames[random.Next(_firstnames.Count)];
                string lastname = _lastnames[random.Next(_lastnames.Count)];
                string domain = _domains[random.Next(_domains.Count)];
                customer.Name = $"{firstname} {lastname}";
                customer.Email = $"{firstname}.{lastname}@{domain}";
                customer.Phone = generatePhoneNumber();
                customer.CreatedAt = DateTime.UtcNow.AddDays(-2);
                customer.UpdatedAt = DateTime.UtcNow;
                _customers.Add(customer);
            }
            
            for (int i = 1; i <= 10 ; i++)
            {
                Movie movie = new();
                movie.Id = i;
                movie.Title = _movieNamePrefixes[random.Next(_movieNamePrefixes.Count)] 
                            + _movieNameAdjectives[random.Next(_movieNameAdjectives.Count)] 
                            + _movieNameNouns[random.Next(_movieNameNouns.Count)];
                movie.Rating = _rating[random.Next(_rating.Count)];
                movie.Description = "description";
                movie.CreatedAt = DateTime.UtcNow.AddDays(-1 -random.Next(10));
                movie.UpdatedAt = DateTime.UtcNow.AddDays(-1);
                movie.RuntimeMins = 60 + random.Next(120);
                _movies.Add(movie);
            }

            for (int i = 1; i <= 30 ; i++)
            {
                Screening screening = new();
                screening.Id = i;
                screening.Capacity = 50 + random.Next(50);
                screening.ScreenNumber = 1 + random.Next(5);
                screening.StartsAt = DateTime.UtcNow.AddDays(random.Next(10));
                screening.MovieId = _movies[random.Next(_movies.Count)].Id;
                screening.CreatedAt = DateTime.UtcNow.AddDays(-10 -random.Next(10));
                screening.UpdateAt = DateTime.UtcNow.AddDays(-random.Next(10));
                _screenings.Add(screening);
            }

            for (int i = 1; i <= 100; i++)
            {
                Ticket ticket = new();
                ticket.Id = i;
                ticket.NumSeats = 1 + random.Next(10);
                ticket.CreatedAt = DateTime.UtcNow.AddDays(-random.Next(10));
                ticket.UpdatedAt = DateTime.UtcNow;
                ticket.CustomerId = _customers[random.Next(_customers.Count)].Id;
                ticket.ScreeningId = _screenings[random.Next(_screenings.Count)].Id;
                _tickets.Add(ticket);
            }

        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }

        
    }
}
