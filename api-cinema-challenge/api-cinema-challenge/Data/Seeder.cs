using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        private List<(string, string, string)> _customerData = new List<(string, string, string)>()
        {
            ("Jonas", "Jonas@booleanExperis.com", "+4785672819"),
            ("Nigel", "Nigel@booleanExperis.com", "+4454316548"),
            ("David", "David@booleanExperis.com", "+4498741897"),
            ("AJ", "AJ@booleanExperis.com", "+4716716214"),
            ("John", "John@booleanExperis.com", "+2754254372")
        };

        private List<(string, string, string)> _movieData = new List<(string, string, string)>()
        {
            ("Terminator",  "PG-16", "Good robot fighting bad robot to save the future"),
            ("Avatar", "PG-13", "Blue psychedelic monkey people have sex with their tails and are trying to save their planet from bad humans"),
            ("Lord of the rings", "PG-13", "Boys trip where friends are trying to burn their buds marrige ring to save him"),
            ("The Matrix", "PG-16", "Red or blue pill? You choose"),
            ("Finding Nemo", "PG-8", "Fish and chips")
        };

        public Seeder()
        {
            Random rnd = new Random();

            DateTime now = DateTime.UtcNow;

            for (int i = 0; i < _customers.Count; i++)
            {
                _customers.Add(new Customer() { 
                    Id = i + 1, 
                    Name = _customerData[i].Item1, 
                    Email = _customerData[i].Item2, 
                    Phone = _customerData[i].Item3, 
                    CreatedAt = now, 
                    UpdatedAt = now });
            }

            for (int i = 0; i < _movieData.Count; i++)
            {
                _movies.Add(new Movie() { 
                    Id = i + 1, 
                    Title = _movieData[i].Item1, 
                    Rating = _movieData[i].Item2, 
                    Description = _movieData[i].Item3, 
                    CreatedAt = now, 
                    UpdatedAt = now });
            }

            for (int i = 0; i < _customers.Count * 2; i++)
            {
                _screenings.Add(new Screening() { 
                    Id = i + 1, 
                    ScreenNumber = rnd.Next(30,200), 
                    Capacity = rnd.Next(30, 80), 
                    StartsAt = now + (TimeSpan.FromHours(i + 1)),
                    MovieId = rnd.Next(1, _movies.Count + 1),
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }

            for (int i = 0; i < _customers.Count * 3; i++)
            {
                _tickets.Add(new Ticket()
                {
                    Id = i + 1,
                    NumSeats = rnd.Next(1, 9),
                    CustomerId = rnd.Next(1, _customers.Count + 1),
                    ScreeningId = rnd.Next(1, _screenings.Count + 1),
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }
        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
    }
}
