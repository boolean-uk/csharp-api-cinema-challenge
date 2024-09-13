using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Numerics;

namespace api_cinema_challenge.Data
{
    public class Seeder
    { 
        private List<Customer> _customers = new();
        private List<Movie> _movies = new();
        private List<Screening> _screenings = new();
        private List<Ticket> _tickets = new();

        public Seeder()
        {
            _customers.Add(new Customer() { Id = 1, Name = "Anne Anneson", Email = "anne@anne.com", PhoneNumber = "47473828", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _customers.Add(new Customer() { Id = 2, Name = "Bent Bentson", Email = "bent@bentson.com", PhoneNumber = "33929274", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _customers.Add(new Customer() { Id = 3, Name = "Carl Carlson", Email = "carl@carlson.com", PhoneNumber = "98472288", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _movies.Add(new Movie() { Id = 1, Title = "Harry Potter and The Philosphers Stone", Rating = "Pg-13", Description = "You're a wizard Harry", DurationMinutes = 190, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _movies.Add(new Movie() { Id = 2, Title = "Harry Potter and The Chamber of Secrets", Rating = "Pg-13", Description = "You're still a wizard Harry", DurationMinutes = 200, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _movies.Add(new Movie() { Id = 3, Title = "Harry Potter and The Prizoner of Azkaban", Rating = "Pg-13", Description = "You're a still still a wizard Harry", DurationMinutes = 170, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _movies.Add(new Movie() { Id = 4, Title = "Harry Potter and The Half Blood Prince", Rating = "Pg-13", Description = "You're a still still still a wizard Harry", DurationMinutes = 170, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _screenings.Add(new Screening() { Id = 1, ScreenNumber = 1, Capacity = 100, MovieId = 1, StartsAt = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }); 
            _screenings.Add(new Screening() { Id = 2, ScreenNumber = 2, Capacity = 200, MovieId = 2, StartsAt = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }); 
            _tickets.Add(new Ticket() { Id = 1, NumSeats = 2, CustomerId = 1, ScreeningId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            _tickets.Add(new Ticket() { Id = 2, NumSeats = 4, CustomerId = 2, ScreeningId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
        }


        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }
    }
}
