using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        public int displayId = 1;
        public int ticketId = 1;
        private List<string> _prefix = new List<string>()
        {
            "The ",
            "A ",
            "",
            "",
            ""
        };

        private List<string> _firstMovieWord = new List<string>() 
        {
            "Fantastical ", 
            "Mystical ",
            "Legendary ",
            "Obtuse ", 
            "Stubborn ", 
            "Happy ",
            "Angry ",
            "Sad ",
            "Depressing ",
            "Depressed ",
            "Flimsy ",
            "",
            "",
        };

        private List<string> _secondMovieWord = new List<string>() 
        {
            "Goose",
            "Building",
            "Man",
            "Woman",
            "Dog",
            "Car",
            "Airplane",
            "Donkey",
            "Cat",
            "Computer",
            "Bread"
        };

        private List<string> _ratings = new List<string>() 
        {
            "G", 
            "PG", 
            "PG-13", 
            "R",
            "NC-17"
        };

        private List<string> _firstNames = new List<string>() 
        {
            "Robert", 
            "Rob", 
            "Bob",
            "Bobby",
            "Jim",
            "Cid",
            "Allen",
            "Jacob",
            "Timothy",
            "William",
            "Will",
            "Rudeus",
            "Ellen",
            "Sara",
            "Elisabeth",
            "Alice",
            "Maria",
            "Kate",
            "Audrey"
        };

        private List<string> _lastNames = new List<string>() 
        {
            "Smith",
            "Johnson",
            "Kagenou",
            "Baker",
            "Williams",
            "Greyrat",
            "Brown",
            "Jones",
            "Miller",
            "Davis",
            "Garcia",
            "Rodriguez",
            "Martinez"
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

        private List<Tuple<int, int>> _rooms = new List<Tuple<int, int>>() 
        {
            new Tuple<int, int>(1, 15),
            new Tuple<int, int>(2, 25),
            new Tuple<int, int>(3, 73),
            new Tuple<int, int>(4, 32),
            new Tuple<int, int>(5, 24),
            new Tuple<int, int>(6, 73),
            new Tuple<int, int>(7, 22),
            new Tuple<int, int>(8, 92),
            new Tuple<int, int>(9, 8),
            new Tuple<int, int>(10, 62),
            new Tuple<int, int>(11, 52),
            new Tuple<int, int>(12, 38),
            new Tuple<int, int>(13, 42),
            new Tuple<int, int>(14, 29),
            new Tuple<int, int>(15, 62),
            new Tuple<int, int>(16, 23),
            new Tuple<int, int>(17, 67),
            new Tuple<int, int>(18, 52),
            new Tuple<int, int>(19, 72),
            new Tuple<int, int>(20, 79)
        };

        private List<Display> _displays = new List<Display>();
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder() 
        {
            Random rngCus = new Random(1234);
            Random rngMov = new Random(4321);
            Random rngTime = new Random(6789);
            Random rngScr = new Random(9876);
            Random rngTic = new Random(1289);

            for (int i = 1; i < 30; i++)
            {
                Movie movie = new Movie();
                movie.MovieId = i;
                movie.Title = $"" +
                    $"{_prefix[rngMov.Next(_prefix.Count)]}" +
                    $"{_firstMovieWord[rngMov.Next(_firstMovieWord.Count)]}" +
                    $"{_secondMovieWord[rngMov.Next(_secondMovieWord.Count)]}";
                movie.Rating = _ratings[rngMov.Next(_ratings.Count)];
                movie.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam in gravida neque. Aenean varius justo tellus, eget sodales quam tristique et. Sed tempor ipsum augue, non ultrices elit tempor sed. Praesent est neque, bibendum vitae quam pharetra, tincidunt volutpat odio. Phasellus a aliquam urna, faucibus auctor purus. Etiam nec urna lobortis, dictum nulla eu, euismod felis. Donec vitae urna condimentum, tristique est in, elementum erat. Vivamus enim dolor, tempor in augue ac, varius consequat ipsum. ";
                movie.RuntimeMinutes = rngMov.Next(90, 450);

                movie.CreatedAt = DateTime.SpecifyKind(new DateTime(rngTime.Next(2000, DateTime.Now.Year+1), rngTime.Next(1, 12), rngTime.Next(1,29)), DateTimeKind.Utc);
                movie.UpdatedAt = movie.CreatedAt;

                _movies.Add(movie);
            }

            for (int i = 1; i < 50; i++) 
            {
                Customer customer = new Customer();

                string firstName = _firstNames[rngCus.Next(_firstNames.Count)];
                string lastName = _lastNames[rngCus.Next(_lastNames.Count)];

                customer.CustomerId = i;
                customer.CustomerName = $"{firstName} {lastName}";
                customer.Email = $"{firstName}.{lastName}@{_domain[rngCus.Next(_domain.Count)]}";
                customer.PhoneNumber = $"+{rngCus.Next(0,998):D2}{rngCus.Next(Int32.MaxValue):D8}";

                customer.CreatedAt = DateTime.SpecifyKind(
                    new DateTime(
                        rngTime.Next(1898, DateTime.Now.Year + 1), 
                        rngTime.Next(1, 12), 
                        rngTime.Next(1, 29), 
                        rngTime.Next(0, 24), 
                        rngTime.Next(0, 60), 
                        rngTime.Next(0, 60)
                        ), DateTimeKind.Utc);
                customer.UpdatedAt = customer.CreatedAt;

                _customers.Add(customer);
            }

            // GENERATE DISPLAYS
            foreach (Tuple<int, int> room in _rooms)
            {
                Display display = new Display();
                display.DisplayId = displayId++;
                display.ScreenNumber = room.Item1;
                display.Capacity = room.Item2;

                display.CreatedAt = DateTime.SpecifyKind(
                    new DateTime(
                        rngTime.Next(1898, DateTime.Now.Year + 1),
                        rngTime.Next(1, 12),
                        rngTime.Next(1, 29),
                        rngTime.Next(0, 24),
                        rngTime.Next(0, 60),
                        rngTime.Next(0, 60)
                    ), DateTimeKind.Utc);
                display.UpdatedAt = display.CreatedAt;

                _displays.Add(display);
            }

            // GENERATE SCREENINGS
            for (int i = 1; i < 100; i++) 
            {
                Screening screening = new Screening();
                screening.ScreeningId = i;
                screening.DisplayId = _displays[rngScr.Next(_displays.Count)].DisplayId;
                screening.MovieId = _movies[rngScr.Next(_movies.Count)].MovieId;

                DateTime createdTime = DateTime.SpecifyKind(
                    new DateTime(
                        rngTime.Next(1898, DateTime.Now.Year + 1),
                        rngTime.Next(1, 12),
                        rngTime.Next(1, 29),
                        rngTime.Next(0, 24),
                        rngTime.Next(0, 60),
                        rngTime.Next(0, 60)
                        ), DateTimeKind.Utc);
                DateTime startingTime = createdTime.Add(TimeSpan.FromHours(rngScr.Next(720)));

                screening.Starts = DateTime.SpecifyKind(startingTime, DateTimeKind.Utc);
                screening.CreatedAt = createdTime;
                screening.UpdatedAt = screening.CreatedAt;

                _screenings.Add(screening);
            }

            // GENERATE TICKETS
            foreach (Screening screening in _screenings) 
            {
                Display display = _displays.Where(d => d.DisplayId == screening.DisplayId).First();
                int ticketsLeft = rngTic.Next((int)(display.Capacity * 0.7));
                while (ticketsLeft > 0)
                {
                    Ticket ticket = new Ticket();

                    ticket.TicketId = ++ticketId;

                    Customer customer = _customers[rngTic.Next(_customers.Count)];
                    ticket.CustomerId = customer.CustomerId;
                    ticket.ScreeningId = screening.ScreeningId;

                    int seatsTaken = 0;
                    if (ticketsLeft > 4)
                    {
                         seatsTaken = rngTic.Next(1, 4);
                    } 
                    else 
                    {
                        seatsTaken = rngTic.Next(1, ticketsLeft);
                    }
                    ticketsLeft -= seatsTaken;
                    ticket.NumberOfSeats = seatsTaken;

                    ticket.CreatedAt = DateTime.SpecifyKind(
                    new DateTime(
                        rngTime.Next(1898, DateTime.Now.Year + 1),
                        rngTime.Next(1, 12),
                        rngTime.Next(1, 29),
                        rngTime.Next(0, 24),
                        rngTime.Next(0, 60),
                        rngTime.Next(0, 60)
                        ), DateTimeKind.Utc);
                    ticket.UpdatedAt = ticket.CreatedAt;

                    _tickets.Add(ticket);
                }
            }
        }
        public List<Customer> Customers { get { return _customers; } }

        public List<Movie> Movies { get { return _movies; } }

        public List<Screening> Screenings { get { return _screenings; } }

        public List<Ticket> Tickets { get { return _tickets; } }

        public List<Display> Displays { get { return _displays; } }
    }
}
