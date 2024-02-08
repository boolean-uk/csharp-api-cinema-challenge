using api_cinema_challenge.Models.JunctionModel;
using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private int displayId = 1;
        private int ticketId = 1;
        private int globalSeatId = 1;
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

        private List<Tuple<int, int>> _rooms = new List<Tuple<int, int>>();

        private List<Display> _displays = new List<Display>();
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Seat> _seats = new List<Seat>();
        private List<TicketSeat> _ticketSeats = new List<TicketSeat>();

        public Seeder() 
        {
            Random rngCus = new Random(1234);
            Random rngMov = new Random(4321);
            Random rngTime = new Random(6789);
            Random rngScr = new Random(9876);
            Random rngTic = new Random(1289);
            Random rngSeat = new Random(152);

            for (int i = 1; i < 20; i++)
            {

                int seats = rngSeat.Next(12, 150);
                int rows = rngSeat.Next(3, Math.Max(6, (int)seats / 6));
                int seatPerRow = (int)(seats/rows);

                for (int j = 1; j <= seats; j++)
                {
                    int RowNumber = (int)(j -1 / seatPerRow) + 1;
                    int seatNumber = (j - 1) % seatPerRow + 1;

                    int seatId = (i * 10000) + j;

                    Seat seat = new Seat() { SeatId = globalSeatId++, RowNumber = RowNumber, SeatNumber = seatNumber , DisplayId = i};
                    _seats.Add(seat);
                    
                }
                _rooms.Add(new Tuple<int, int>(i, seats));
            }


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
                display.DisplayId = room.Item1;
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
                         seatsTaken = rngTic.Next(1, 5);
                    } 
                    else 
                    {
                        seatsTaken = rngTic.Next(1, ticketsLeft);
                    }

                    List<int> selectedSeats = new List<int>();

                    for (int i = 0; i < seatsTaken; i++)
                    {
                        List<int> availableSeats = _seats
                            .Where(s => s.DisplayId == display.DisplayId && !selectedSeats.Contains(s.SeatId))
                            .Select(s => s.SeatId)
                            .ToList();
                        if (availableSeats.Count() > 0)
                        {
                            int selectedSeatIndex = rngTic.Next(0, availableSeats.Count);
                            int selectedSeatId = availableSeats[selectedSeatIndex];
                            selectedSeats.Add(selectedSeatId);
                            availableSeats.RemoveAt(selectedSeatIndex);

                            TicketSeat ticketSeat = new TicketSeat()
                            {
                                TicketId = ticket.TicketId,
                                SeatId = selectedSeatId,
                                DisplayId = display.DisplayId
                            };
                            _ticketSeats.Add(ticketSeat);
                        }
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

        public List<Seat> Seats { get { return _seats; } }

        public List<TicketSeat> TicketSeats {  get { return _ticketSeats; } }
    }
}
