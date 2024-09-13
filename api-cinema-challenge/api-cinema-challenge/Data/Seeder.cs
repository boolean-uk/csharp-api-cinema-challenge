using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Movie> _movies;
        private List<Customer> _customers;
        private List<Screening> _screenings;
        private List<Ticket> _tickets;

        public Seeder()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Inception",
                    RuntimeMins = 148,
                    Rating = "PG-13",
                    Description = "A skilled thief, Dom Cobb, who can infiltrate and steal information from dreams, is tasked with planting an idea into a target's subconscious." +
                    " As the mission becomes more dangerous, Cobb confronts his own troubled past.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Movie()
                {
                    Id = 2,
                    Title = "The Dark Knight",
                    RuntimeMins = 152,
                    Description = "Batman faces his greatest challenge yet as the Joker wreaks havoc on Gotham City. " +
                    "As chaos ensues, Bruce Wayne must grapple with the cost of being a hero and the line between good and evil.",
                    Rating = "PG-13",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Movie()
                {
                    Id = 3,
                    Title = "Interstellar",
                    RuntimeMins = 169,
                    Rating = "PG-13",
                    Description = "In a future where Earth is on the brink of collapse, a team " +
                    "of astronauts travels through a wormhole in search of a new home for humanity. " +
                    "The film explores themes of time, space, and love as a survival force.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Movie()
                {
                    Id = 4,
                    Title = "The Matrix",
                    RuntimeMins = 136,
                    Rating = "R",
                    Description = "A hacker, Neo, discovers that reality as he knows it is a simulation " +
                    "controlled by machines. He joins a group of rebels to fight against the machines " +
                    "and free humanity from their virtual prison.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
            };

            _customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Phone = "555-123-4567",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com",
                    Phone = "555-234-5678",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Michael Johnson",
                    Email = "michael.johnson@example.com",
                    Phone = "555-345-6789",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Customer()
                {
                    Id = 4,
                    Name = "Emily Davis",
                    Email = "emily.davis@example.com",
                    Phone = "555-456-7890",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Customer()
                {
                    Id = 5,
                    Name = "David Wilson",
                    Email = "david.wilson@example.com",
                    Phone = "555-567-8901",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
            };

            _screenings = new List<Screening>()
            {
                new Screening()
                {
                    Id = 1,
                    Capacity = 100,
                    StartsAt = DateTime.UtcNow.AddDays(1), // Screening 1 day from now
                    CreatedAT = DateTime.UtcNow,
                    UpdatedAT = DateTime.UtcNow,
                    MovieId = 1 // Inception
                },
                new Screening()
                {
                    Id = 2,
                    Capacity = 120,
                    StartsAt = DateTime.UtcNow.AddDays(2), // Screening 2 days from now
                    CreatedAT = DateTime.UtcNow,
                    UpdatedAT = DateTime.UtcNow,
                    MovieId = 2 // The Dark Knight
                }
            };

            _tickets = new List<Ticket>()
            {
                new Ticket()
                {
                    Id = 1,
                    NumSeats = 1, // Assuming each ticket reserves 1 seat
                    CreatedAT = DateTime.UtcNow,
                    UpdatedAT = DateTime.UtcNow,
                    ScreeningId = 1, // Screening for Inception
                    CustomerID = 1 // John Doe
                },
                new Ticket()
                {
                    Id = 2,
                    NumSeats = 1,
                    CreatedAT = DateTime.UtcNow,
                    UpdatedAT = DateTime.UtcNow,
                    ScreeningId = 1, // Screening for Inception
                    CustomerID = 2 // Jane Smith
                },
                new Ticket()
                {
                    Id = 3,
                    NumSeats = 1,
                    CreatedAT = DateTime.UtcNow,
                    UpdatedAT = DateTime.UtcNow,
                    ScreeningId = 2, // Screening for The Dark Knight
                    CustomerID = 3 // Michael Johnson
                },
                new Ticket()
                {
                    Id = 4,
                    NumSeats = 1,
                    CreatedAT = DateTime.UtcNow,
                    UpdatedAT = DateTime.UtcNow,
                    ScreeningId = 2, // Screening for The Dark Knight
                    CustomerID = 4 // Emily Davis
                },
                new Ticket()
                {
                    Id = 5,
                    NumSeats = 1,
                    CreatedAT = DateTime.UtcNow,
                    UpdatedAT = DateTime.UtcNow,
                    ScreeningId = 1, // Screening for Inception
                    CustomerID = 5 // David Wilson
                }
            };
        }

        public List<Movie> Movies { get { return _movies; } }
        public List<Ticket> Tickets { get { return _tickets; } }
        public List<Customer> Customers { get { return _customers; } }
        public List<Screening> Screenings { get { return _screenings; } }

    }
}
