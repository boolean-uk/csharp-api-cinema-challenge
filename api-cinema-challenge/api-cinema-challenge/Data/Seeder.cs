using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Movie> _movies = [];
        private List<Screening> _screenings = [];
        private List<Customer> _customers = [];

        public Seeder() 
        { 
            Movie movie1 = new Movie() {
                Id=1, 
                Title="Great Movie 4", 
                Description="One of the movies of all time",
                Rating = "PG-13",
                RuntimeMins =2000,
                UpdatedAt=DateTime.UtcNow,

            };
            Movie movie2 = new Movie() {
                Id = 2,
                Title = "Great Movie 5",
                Description = "One more of the movies of all time",
                Rating = "PG-13",
                RuntimeMins = 200,
                UpdatedAt = DateTime.UtcNow,
            };
            _movies.Add(movie1);
            _movies.Add(movie2);

            Screening screening1 = new Screening()
            {
                Id = 1,
                ScreenNumber = 1,
                Capacity = 190,
                StartsAt = DateTime.UtcNow,
                UpdatedAt= DateTime.UtcNow,
                MovieId = movie1.Id,
            };
            Screening screening2 = new Screening()
            {
                Id = 2,
                ScreenNumber = 3,
                Capacity = 140,
                StartsAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                MovieId = movie2.Id,
            };
            _screenings.Add(screening1);
            _screenings.Add(screening2);


            Customer customer1 = new Customer() 
            {
                Id=1,
                Name="Bill Crosby",
                Phone="78707870",
                updatedAt= DateTime.UtcNow,
            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Neil Young",
                Phone = "78707870",
                updatedAt = DateTime.UtcNow,
            };

            _customers.Add(customer1);
            _customers.Add(customer2);
        }

        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get {  return _screenings; } }

        public List<Customer> Customers { get {  return _customers; } }
    }
}
