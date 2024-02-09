using api_cinema_challenge.Data.SeedData.StaticData;
using api_cinema_challenge.Models.JunctionModel;
using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Data.SeedData
{
    public class Seeder
    {
        private int ticketId = 1;

        private int numberOfDisplays = 20;
        private int numberOfMovies = 50;
        private int numberOfCustomers = 400;
        private int numberOfScreenings = 200;

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
            Random rngCus = new Random(1234);
            Random rngMov = new Random(4321);
            Random rngTime = new Random(6789);
            Random rngScr = new Random(9876);
            Random rngTic = new Random(1289);
            Random rngSeat = new Random(152);

            for (int i = 1; i < numberOfDisplays; i++)
            {

                int seats = rngSeat.Next(12, 150);
                int rows = rngSeat.Next(3, Math.Max(6, seats / 6));
                int seatPerRow = seats / rows;


                for (int j = 1; j <= seats; j++)
                {
                    int RowNumber = j - 1 / seatPerRow + 1;
                    int seatNumber = (j - 1) % seatPerRow + 1;

                    Seat seat = new Seat();
                    seat.SeatId = j;
                    seat.RowNumber = RowNumber;
                    seat.SeatNumber = seatNumber;
                    seat.DisplayId = i;

                    _seats.Add(seat);

                }
                _rooms.Add(new Tuple<int, int>(i, seats));
            }


            for (int i = 1; i < numberOfMovies; i++)
            {
                Movie movie = new Movie();
                movie.MovieId = i;
                movie.Title = $"" +
                    $"{_prefix[rngMov.Next(_prefix.Count)]}" +
                    $"{_firstMovieWord[rngMov.Next(_firstMovieWord.Count)]} " +
                    $"{_secondMovieWord[rngMov.Next(_secondMovieWord.Count)]}";
                movie.Rating = _ratings[rngMov.Next(_ratings.Count)];
                movie.Description = _movieDesc[rngMov.Next(_movieDesc.Count)];
                movie.RuntimeMinutes = rngMov.Next(90, 450);

                movie.CreatedAt = DateTime.SpecifyKind(new DateTime(rngTime.Next(2000, DateTime.Now.Year + 1), rngTime.Next(1, 12), rngTime.Next(1, 29)), DateTimeKind.Utc);
                movie.UpdatedAt = movie.CreatedAt;

                _movies.Add(movie);
            }

            for (int i = 1; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer();

                string firstName = _firstNames[rngCus.Next(_firstNames.Count)];
                string lastName = _lastNames[rngCus.Next(_lastNames.Count)];

                customer.CustomerId = i;
                customer.CustomerName = $"{firstName} {lastName}";
                customer.Email = $"{firstName}.{lastName}@{_domain[rngCus.Next(_domain.Count)]}";
                customer.PhoneNumber = $"+{rngCus.Next(0, 998):D2}{rngCus.Next(int.MaxValue):D8}";

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
            for (int i = 1; i < numberOfScreenings; i++)
            {
                Screening screening = new Screening();
                screening.ScreeningId = i;
                Display display = _displays[rngScr.Next(_displays.Count)];
                screening.DisplayId = display.DisplayId;
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

                int ticketsLeft = rngTic.Next(0, (int)(display.Capacity * 0.8));
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

                    for (int i = 0; i < seatsTaken && seatsForScreening.Count > 0; i++)
                    {
                        int tsIndex = rngTic.Next(seatsForScreening.Count);
                        TicketSeat ticketSeat = seatsForScreening[tsIndex];
                        seatsForScreening.Remove(ticketSeat);
                        ticketSeat.TicketId = ticket.TicketId;
                    }

                    ticketsLeft -= seatsTaken;

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

        public List<TicketSeat> TicketSeats { get { return _ticketSeats; } }
    }
}
