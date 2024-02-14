using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Movie> _movies = new List<Movie>();
        private List<Customer> _customers = new List<Customer>();
        private List<Ticket> _tickets = new List<Ticket>();
        private List<Screening> _screenings = new List<Screening>();

        private List<string> _fullnames = new List<string>()
        {
            "John Doe",
            "Hannibal Lecter",
            "Anakin Skywalker",
            "Bilbo Baggins",
            "Gandalf",
            "Monkey D Luffy",
            "Roronoa Zoro",
            "Charlotte Katakuri",
            "Edward Newgate",
            "Figarland Shanks"
        };

        private List<string> _emails = new List<string>() 
        {
            "youknowme@gmail.com",
            "haveiseenyoubefore@hotmail.com",
            "didyouseeme@microsoft.com",
            "idontknowyou@yahoo.com",
            "didyouknowme@wordpress.com",
            "itschewsdayinnit@microsoft.co.uk",
            "itswednesdaymydudes@gmail.co.us",
            "imlost@geoguesser.com"
        };

        private List<string> _movienames = new List<string>()
        {
            "Revenge of the sith",
            "Lord of the rings: Two towers",
            "The hobbit",
            "John wick 4",
            "The Equalizer 2",
            "100 åringen som hoppa ut vinduet og forsvant",
            "103 Mercies",
            "Monster INC",
            "I have no ideas left"
        };

        private List<string> _rating = new List<string>()
        {
            "PG-13",
            "G",
            "R",
            "PG",
            "NC-17"
        };

        static Random Random = new Random();
        private string GeneratePhoneNumber()
        {
            return Random.Next(10000000, 100000000).ToString();
        }

        Random random = new Random();

        public Seeder() 
        {
            for(int i = 1;  i < 10 ; i++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                customer.Name = _fullnames[random.Next(_fullnames.Count)];
                customer.Email = _emails[random.Next(_emails.Count)];
                customer.Phone = GeneratePhoneNumber();
                customer.updatedAt = DateTime.UtcNow;
                _customers.Add(customer);
            }

            for(int i = 1;i < 10 ; i++)
            {
                Movie movie = new Movie();
                movie.Id = i;
                movie.Title = _movienames[random.Next(_movienames.Count)];
                movie.Rating = _rating[random.Next(_rating.Count)];
                movie.Description = "description";
                movie.updatedAt = DateTime.UtcNow.AddDays(+1);
                movie.RuntimeMins = 60 + random.Next(120);
                _movies.Add(movie);
            }

            for( int i = 1;i < 20; i++)
            {
                Screening screening = new Screening();
                screening.Id = i;
                screening.capacity = 50 + random.Next(50);
                screening.screenNumber = 1 + random.Next(7);
                screening.startsAt = DateTime.UtcNow.AddDays(random.Next(10));
                screening.MovieId = _movies[random.Next(_movies.Count)].Id;
                screening.updatedAt = DateTime.UtcNow.AddDays(+1);
                _screenings.Add(screening);
            }

            for(int i = 1; i < 100 ; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = i;
                ticket.numSeats = 1 + random.Next(5);
                ticket.customerId = _customers[random.Next(_customers.Count)].Id;
                ticket.screeningId = _screenings[random.Next(_screenings.Count)].Id;
                ticket.updatedAt = DateTime.UtcNow.AddDays(+1); 
                _tickets.Add(ticket);
            }
        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get {  return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get {  return _tickets; } }
    }
}
