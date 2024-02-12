using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private static List<string> _firstnames = new List<string>()
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
            "Kate",
            "Ozzy",
            "Tony",
            "Geezer",
            "Bill",
            "Ronnie",
            "Keith",
            "Charlie",
            "Brian",
            "Roger",
            "Ginger"
        };
        private static List<string> _lastnames = new List<string>()
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
            "Middleton",
            "Osbourne",
            "Iommi",
            "Butler",
            "Ward",
            "Dio",
            "Moon",
            "Watts",
            "May",
            "Daltrey",
            "Baker"
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

        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {
            CustomerSeeder();
            MovieSeeder();
            ScreeningSeeder();
            TicketSeeder();
        }

        //10 Customers
        public void CustomerSeeder()
        {
            Random customerRandom = new Random();

            for (int x = 1; x < 11; x++)
            {
                string firstname = _firstnames[customerRandom.Next(_firstnames.Count)];
                string lastname = _lastnames[customerRandom.Next(_lastnames.Count)];

                Customer customer = new Customer();
                customer.Id = x;
                customer.Name = $"{firstname} {lastname}";
                customer.Email = $"{firstname}.{lastname}@{_domain[customerRandom.Next(_domain.Count)]}".ToLower();
                customer.Phone = $"{customerRandom.Next(4, 10)}{customerRandom.Next(0, 10)} {customerRandom.Next(0, 10)}{customerRandom.Next(0, 10)} {customerRandom.Next(0, 10)}{customerRandom.Next(0, 10)} {customerRandom.Next(0, 10)}{customerRandom.Next(0, 10)}";
                customer.CreatedAt = DateTime.UtcNow;
                customer.UpdatedAt = DateTime.UtcNow;
                _customers.Add(customer);
            }
        }

        //5 Movies offered in the cinema
        public void MovieSeeder()
        {
            Movie movie1 = new Movie
            {
                Id = 1,
                Title = "Goodfellas",
                Rating = "R",
                Description = "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.",
                Runtime = 148,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            Movie movie2 = new Movie
            {
                Id = 2,
                Title = "Scarface",
                Rating = "R",
                Description = "In 1980 Miami, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.",
                Runtime = 170,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            Movie movie3 = new Movie
            {
                Id = 3,
                Title = "The VVitch: A New-England Folktale",
                Rating = "R",
                Description = "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.",
                Runtime = 93,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            Movie movie4 = new Movie
            {
                Id = 4,
                Title = "Nosferatu",
                Rating = "Not Rated",
                Description = "Vampire Count Orlok expresses interest in a new residence and real estate agent Hutter's wife.",
                Runtime = 94,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            Movie movie5 = new Movie
            {
                Id = 5,
                Title = "Chicken Run",
                Rating = "G",
                Description = "When a cockerel apparently flies into a chicken farm, the chickens see him as an opportunity to escape their evil owners.",
                Runtime = 84,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            _movies.Add(movie1);
            _movies.Add(movie2);
            _movies.Add(movie3);
            _movies.Add(movie4);
            _movies.Add(movie5);
        }
        
        //5 Screenings
        public void ScreeningSeeder()
        {
            Random screeningRandom = new Random();

            for(int i = 1; i<6; i++)
            {
                Screening screening = new Screening();
                screening.Id = i;
                screening.ScreenNumber = screeningRandom.Next(1, 4);
                screening.Capacity = screeningRandom.Next(25, 251);
                screening.MovieId = screeningRandom.Next(1, 6);
                screening.StartsAt = DateTime.UtcNow.AddHours(screeningRandom.Next(3, 6));
                screening.CreatedAt = DateTime.UtcNow;
                screening.UpdatedAt = DateTime.UtcNow;
                _screenings.Add(screening);
            }
        }

        //20 Tickets
        public void TicketSeeder()
        {
            Random ticketRandom = new Random();

            for (int i = 1; i < 51; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = i;
                ticket.ScreeningId = ticketRandom.Next(1, 6);
                ticket.CustomerId = ticketRandom.Next(1, 11);
                ticket.NumSeats = ticketRandom.Next(1, 8);
                ticket.CreatedAt = DateTime.UtcNow;
                ticket.UpdatedAt = DateTime.UtcNow;
                _tickets.Add(ticket);
            }
        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
    }
}
