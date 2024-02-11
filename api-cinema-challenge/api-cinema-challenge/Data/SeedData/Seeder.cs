using api_cinema_challenge.Data.SeedData.StaticData;
using api_cinema_challenge.Models.JunctionModel;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Utils;

namespace api_cinema_challenge.Data.SeedData
{
    public class Seeder
    {
        private Random rng = new Random(99663311);

        private int ticketId = 1;

        private int numberOfDisplays = 20;
        private int minimumSeatsPerDisplay = 12;
        private int maximumSeatsPerDisplay = 150;

        private int numberOfMovies = 100;
        private int numberOfCustomers = 400;
        private int numberOfScreenings = 150;

        private List<string> _prefix = MovieInfo.MovieTitlePrefix;

        private List<string> _firstMovieWord = MovieInfo.MovieAdjective;

        private List<string> _secondMovieWord = MovieInfo.MovieNouns;

        private List<string> _ratings = MovieInfo.Ratings;

        private List<string> _movieDesc = MovieInfo.MovieDescriptions;

        private List<string> _firstNames = GenericPeople.FirstNames;

        private List<string> _lastNames = GenericPeople.LastNames;

        private List<string> _domain = GenericPeople.Domains;



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

            for (int i = 1; i < numberOfDisplays; i++)
            {

                int seats = rng.Next(minimumSeatsPerDisplay, maximumSeatsPerDisplay);

                List<Seat> generatedSeats = SeatGenerator.FillSeat(seats, i);

                _seats.AddRange(generatedSeats);
                _rooms.Add(new Tuple<int, int>(i, seats));
            }


            for (int i = 1; i < numberOfMovies; i++)
            {
                Movie movie = new Movie();
                movie.MovieId = i;
                movie.Title = $"" +
                    $"{_prefix[rng.Next(_prefix.Count)]}" +
                    $"{_firstMovieWord[rng.Next(_firstMovieWord.Count)]}" +
                    $"{_secondMovieWord[rng.Next(_secondMovieWord.Count)]}";
                movie.Rating = _ratings[rng.Next(_ratings.Count)];
                movie.Description = _movieDesc[rng.Next(_movieDesc.Count)];
                movie.RuntimeMinutes = rng.Next(90, 450);

                movie.CreatedAt = TimeGenerator
                    .GenerateUTCTimeDate(rng, 2000, DateTime.Now.Year + 1);
                movie.UpdatedAt = movie.CreatedAt;

                _movies.Add(movie);
            }

            for (int i = 1; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer();

                string firstName = _firstNames[rng.Next(_firstNames.Count)];
                string lastName = _lastNames[rng.Next(_lastNames.Count)];

                customer.CustomerId = i;
                customer.CustomerName = $"{firstName} {lastName}";
                customer.Email = $"{firstName}.{lastName}@{_domain[rng.Next(_domain.Count)]}";
                customer.PhoneNumber = $"+{rng.Next(0, 998):D2}{rng.Next(int.MaxValue):D8}";

                customer.CreatedAt = TimeGenerator
                    .GenerateUTCTimeDate(rng, 1898, DateTime.Now.Year + 1);
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

                display.CreatedAt = TimeGenerator
                    .GenerateUTCTimeDate(rng, 1898, DateTime.Now.Year + 1);
                display.UpdatedAt = display.CreatedAt;

                _displays.Add(display);
            }

            // GENERATE SCREENINGS
            for (int i = 1; i < numberOfScreenings; i++)
            {
                Screening screening = new Screening();
                screening.ScreeningId = i;
                Display display = _displays[rng.Next(_displays.Count)];
                screening.DisplayId = display.DisplayId;
                screening.MovieId = _movies[rng.Next(_movies.Count)].MovieId;


                DateTime createdTime = TimeGenerator
                    .GenerateUTCTimeDate(rng, 1898, DateTime.Now.Year + 1);
                DateTime startingTime = createdTime
                    .Add(TimeSpan.FromHours(rng.Next(720)));

                screening.Starts = DateTime.SpecifyKind(startingTime, DateTimeKind.Utc);
                screening.CreatedAt = createdTime;
                screening.UpdatedAt = screening.CreatedAt;

                _screenings.Add(screening);
            }

            // GENERATE TICKETS
            foreach (Screening screening in _screenings)
            {
                Display display = _displays.Where(d => d.DisplayId == screening.DisplayId).First();

                IEnumerable<Seat> seats = _seats.Where(s => s.DisplayId == display.DisplayId);
                List<TicketSeat> seatsForScreening = seats
                    .Select(s => new TicketSeat()
                    {
                        DisplayId = display.DisplayId,
                        ScreeningId = screening.ScreeningId,
                        SeatId = s.SeatId,
                    })
                    .ToList();
                _ticketSeats.AddRange(seatsForScreening);

                int ticketsLeft = rng.Next(0, (int)(display.Capacity * 0.8));
                while (ticketsLeft > 0)
                {
                    Ticket ticket = new Ticket();

                    ticket.TicketId = ticketId++;

                    Customer customer = _customers[rng.Next(_customers.Count)];
                    ticket.CustomerId = customer.CustomerId;
                    ticket.ScreeningId = screening.ScreeningId;

                    int seatsTaken = 0;
                    if (ticketsLeft > 4)
                    {
                        seatsTaken = rng.Next(1, 5);
                    }
                    else
                    {
                        seatsTaken = rng.Next(1, ticketsLeft);
                    }

                    for (int i = 0; i < seatsTaken && seatsForScreening.Count > 0; i++)
                    {
                        int tsIndex = rng.Next(seatsForScreening.Count);
                        TicketSeat ticketSeat = seatsForScreening[tsIndex];
                        seatsForScreening.Remove(ticketSeat);
                        ticketSeat.TicketId = ticket.TicketId;
                    }

                    ticketsLeft -= seatsTaken;

                    ticket.CreatedAt = TimeGenerator
                        .GenerateUTCTimeDate(rng, 1898, DateTime.Now.Year + 1);
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

        public List<TicketSeat> TicketSeats { get { return _ticketSeats; } }
    }
}
