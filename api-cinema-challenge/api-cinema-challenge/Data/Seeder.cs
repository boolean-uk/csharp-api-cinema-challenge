using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Movie> _movies = [];
        private List<Screening> _screenings = [];
        private List<Ticket> _tickets = [];
        private List<Customer> _customers = [];

        private List<string> _names = new List<string>() { "fwjio", "jefow", "feokf", "Fodif", "ocvic", "coiv" };
        private List<string> _movieNames = new List<string>() { "Why", "How", "Wherefore", "Art", "Thou", "Why2" };
        private List<string> _pgs = new() { "PG-13", "PG-18", "PG-418247", "PG-39" };
        private List<string> _phones = new() { "48724242", "42478247", "59854853" };
        private List<string> _emails = new() { "fjiejf@fijefj.com", "whyyyy@doihavetowritethis.net", "seeding@isboring.co.uk" };
        private List<string> _descriptions = new() { "fijsogjoijg eofkofe koeo ke", "oekroe oke oek oek eo ke", "pasopxcopc pcxo pxcxpco " };

        private Random r = new Random();
        public Seeder()
        {
            for (int i = 1; i < 6; i++)
            {
                Customer customer = new Customer()
                {
                    Id = i,
                    Name = _names[r.Next(_names.Count)],
                    Email = _emails[r.Next(_emails.Count)],
                    Phone = _phones[r.Next(_phones.Count)],
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
                _customers.Add(customer);
            }

            for (int i = 1; i < 5; i++)
            {
                Movie movie = new Movie()
                {
                    Id = i,
                    Description = _descriptions[r.Next(_descriptions.Count)],
                    Rating = _pgs[r.Next(_pgs.Count)],
                    Runtime = r.Next(240),
                    Title = _movieNames[r.Next(_movieNames.Count)],
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
                _movies.Add(movie);
            }

            for (int i = 1; i < 5; i++)
            {
                Screening s = new()
                {
                    Id = i,
                    Capacity = r.Next(100),
                    ScreenNumber = r.Next(100),
                    MovieId = _movies[r.Next(_movies.Count)].Id,
                    CreatedAt = DateTime.UtcNow,
                    StartTime = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
                _screenings.Add(s);
            }

            for (int i = 1; i < 5; i++)
            {
                Ticket t = new()
                {
                    Id = i,
                    CustomerId = _customers[r.Next(_customers.Count)].Id,
                    ScreeningId = _screenings[r.Next(_screenings.Count)].Id,
                    SeatNumber = r.Next(100),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
                _tickets.Add(t);
            }

        }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
        public List<Customer> Customers { get { return _customers; } }
    }
}
