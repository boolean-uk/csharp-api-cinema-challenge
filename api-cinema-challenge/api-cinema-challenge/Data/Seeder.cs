using api_cinema_challange.Models;

namespace api_cinema_challange.Seeder
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
        private List<string> _movienames = new List<string>()
        {
            "Casablanca",
            "The Godfather",
            "Pulp Fiction",
            "Forrest Gump",
            "The Shawshank Redemption",
            "Inception",
            "Titanic",
            "The Dark Knight",
            "Schindler's List",
            "The Matrix"
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

        private List<string> _moviedescriptions = new List<string>()
        {
            "A classic romantic drama set during World War II.",
            "A crime epic that follows the Corleone family's rise to power.",
            "Quentin Tarantino's nonlinear crime film with interconnected stories.",
            "The life journey of a man with low intelligence but a kind heart.",
            "A tale of hope and friendship in the confines of Shawshank State Penitentiary.",
            "Christopher Nolan's mind-bending heist thriller.",
            "A tragic love story set against the backdrop of the Titanic's sinking.",
            "The caped crusader faces the Joker in this intense superhero film.",
            "The story of Oskar Schindler and his efforts to save Jews during the Holocaust.",
            "A cyberpunk sci-fi film exploring the nature of reality and human perception."
        };

        private List<string> _movieratings = new List<string>()
        {
            "PG-13",
            "PG-7",
            "PG-18",
            "PG-99"
        };

        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();
        private List<ScreeningTicket> _screening_tickets = new List<ScreeningTicket>();
        private List<CustomerTicket> _customer_tickets = new List<CustomerTicket>();

        public Seeder()
        {

            Random customerRandom = new Random();
            Random movieRandom = new Random();
            Random screeningRandom = new Random();
            Random ticketRandom = new Random();
            Random ratingRandom = new Random();

            for (int y = 1; y < 11; y++)
            {
                Customer customer = new Customer();
                customer.Id = y;
                customer.Name = $"{_firstnames[y - 1]}";
                customer.Email = $"{customer.Name}@{_domain[customerRandom.Next(_domain.Count)]}".ToLower();
                customer.Phone = 555123456;
                customer.CreatedAt = DateTime.UtcNow;
                customer.UpdatedAt = DateTime.UtcNow;
                _customers.Add(customer);
            }

            for (int x = 1; x < 11; x++)
            {
                Movie movie = new Movie();
                movie.Id = x;
                movie.Title = _movienames[movieRandom.Next(_firstnames.Count)];
                movie.Description = _lastnames[movieRandom.Next(_firstnames.Count)];
                movie.RuntimeMins = 120;
                movie.Rating = _movieratings[ratingRandom.Next(_movieratings.Count)];
                movie.CreatedAt = DateTime.UtcNow;
                movie.UpdatedAt = DateTime.UtcNow;
                _movies.Add(movie);
            }


            for (int y = 1; y < 11; y++)
            {
                Screening screening = new Screening();
                screening.Id = y;
                screening.MovieId = _movies[screeningRandom.Next(_movies.Count)].Id;
                screening.screenNumber = y;
                screening.Capacity = 30;
                DateTime startDate = DateTime.UtcNow;

                startDate = startDate.AddHours(screeningRandom.Next(24));

                screening.StartsAt = startDate;
                screening.CreatedAt = DateTime.UtcNow;
                screening.UpdatedAt = DateTime.UtcNow;
                _screenings.Add(screening);
            }

            for (int y = 1; y < 11; y++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = y;
                ticket.NumSeats = 2;
                ticket.CreatedAt = DateTime.UtcNow;
                ticket.UpdatedAt = DateTime.UtcNow;
                _tickets.Add(ticket);
            }

            for (int y = 1; y < 11; y++)
            {
                ScreeningTicket ticket = new ScreeningTicket();
                ticket.ScreeningId = y;
                ticket.TicketId = y;
                _screening_tickets.Add(ticket);
            }

            for (int y = 1; y < 11; y++)
            {
                CustomerTicket customerTicket = new CustomerTicket();
                customerTicket.CustomerId = y;
                customerTicket.TicketId = y;
                _customer_tickets.Add(customerTicket);
            }

        }
        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
        public List<ScreeningTicket> ScreeningTickets { get { return _screening_tickets; } }
        public List<CustomerTicket> CustomerTickets { get { return _customer_tickets; } }

    }
}
