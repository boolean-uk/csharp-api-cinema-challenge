using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Movie> _movies = [];
        private List<Screening> _screenings = [];
        private List<Ticket> _tickets = [];
        private List<Customer> _customers = [];
        public Seeder()
        {
            //todo: seed
        }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
        public List<Customer> Customers { get { return _customers; } }
    }
}
