using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screening = new List<Screening>();

        public Seeder()
        {
            //Movies
            Movie movie1 = new Movie(1, "Harry Potter", "PG-13", "Magic staffs goes boom", 123);
            Movie movie2 = new Movie(2, "Lord Of The Rings", "PG-16", "Swords, Wizards and fun", 205);
            Movie movie3 = new Movie(3, "Frozen", "PG-All", "Singing", 89);

            _movies.Add(movie1);
            _movies.Add(movie2);
            _movies.Add(movie3);

            //Customers
            Customer customer1 = new Customer(1, "Anders Hagen Ottersland", "anderh2@gmail.com", "1234");
            Customer customer2 = new Customer(2, "Nigel Teacher", "Nigel@teacher.com", "90909090");

            _customers.Add(customer1);
            _customers.Add(customer2);

            //Screenings
            Screening screening1 = new Screening(1, 1, 50, DateTime.UtcNow, movie1.Id);
            Screening screening2 = new Screening(2, 2, 100, DateTime.UtcNow, movie2.Id);
            _screening.Add(screening1);
            _screening.Add(screening2);

        }

        public List<Customer> CustomerList { get { return _customers; } }
        public List<Movie> MovieList { get { return _movies; } }
        public List<Screening> ScreeningList { get { return _screening; } }
    }
}
