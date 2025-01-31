using System;
using System.Collections.Generic;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data;

public class CinemaData
{
    public List<Movie> Movies { get; set; }
    public List<Customer> Customers { get; set; }
    public List<Screening> Screenings { get; set; }
    public List<Ticket> Tickets { get; set; }

    public CinemaData()
    {
        var now = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc);

        Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "Inception",
                Rating = "PG-13",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is tasked with planting an idea into the mind of a C.E.O.",
                RuntimeMins = 148,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Movie
            {
                Id = 2,
                Title = "The Dark Knight",
                Rating = "PG-13",
                Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                RuntimeMins = 152,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Movie
            {
                Id = 3,
                Title = "Interstellar",
                Rating = "PG-13",
                Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                RuntimeMins = 169,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Movie
            {
                Id = 4,
                Title = "The Shawshank Redemption",
                Rating = "R",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                RuntimeMins = 142,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Movie
            {
                Id = 5,
                Title = "Dunkirk",
                Rating = "PG-13",
                Description = "Allied soldiers from Belgium, the British Empire, and France are surrounded by the German Army and evacuated during a fierce battle in World War II.",
                RuntimeMins = 106,
                CreatedAt = now,
                UpdatedAt = now
            }
        };

        Customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "John Doe",
                Email = "john.doe@example.com",
                Phone = "123-456-7890",
                CreatedAt = now,
                UpdatedAt = now
            },
            new Customer
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "jane.smith@example.com",
                Phone = "098-765-4321",
                CreatedAt = now,
                UpdatedAt = now
            },
            new Customer
            {
                Id = 3,
                Name = "Emily Davis",
                Email = "emily.davis@example.com",
                Phone = "555-123-4567",
                CreatedAt = now,
                UpdatedAt = now
            },
            new Customer
            {
                Id = 4,
                Name = "Michael Brown",
                Email = "michael.brown@example.com",
                Phone = "444-567-8901",
                CreatedAt = now,
                UpdatedAt = now
            },
            new Customer
            {
                Id = 5,
                Name = "Sarah Johnson",
                Email = "sarah.johnson@example.com",
                Phone = "222-345-6789",
                CreatedAt = now,
                UpdatedAt = now
            }
        };

        Screenings = new List<Screening>
        {
            new Screening
            {
                Id = 1,
                MovieId = 1,
                ScreenNumber = 1,
                Capacity = 100,
                StartsAt = now.AddHours(2),
                CreatedAt = now,
                UpdatedAt = now
            },
            new Screening
            {
                Id = 2,
                MovieId = 4,
                ScreenNumber = 2,
                Capacity = 80,
                StartsAt = now.AddHours(3),
                CreatedAt = now,
                UpdatedAt = now
            },
            new Screening
            {
                Id = 3,
                MovieId = 5,
                ScreenNumber = 3,
                Capacity = 120,
                StartsAt = now.AddDays(1).AddHours(2),
                CreatedAt = now,
                UpdatedAt = now
            },
            new Screening
            {
                Id = 4,
                MovieId = 3,
                ScreenNumber = 1,
                Capacity = 90,
                StartsAt = now.AddDays(1).AddHours(5),
                CreatedAt = now,
                UpdatedAt = now
            },
            new Screening
            {
                Id = 5,
                MovieId = 3,
                ScreenNumber = 2,
                Capacity = 110,
                StartsAt = now.AddHours(6),
                CreatedAt = now,
                UpdatedAt = now
            }
        };

        Tickets = new List<Ticket>
        {
            new Ticket
            {
                Id = 1,
                ScreeningId = 1,
                CustomerId = 1,
                NumSeats = 2,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Ticket
            {
                Id = 2,
                ScreeningId = 2,
                CustomerId = 2,
                NumSeats = 1,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Ticket
            {
                Id = 3,
                ScreeningId = 3,
                CustomerId = 3,
                NumSeats = 4,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Ticket
            {
                Id = 4,
                ScreeningId = 4,
                CustomerId = 4,
                NumSeats = 3,
                CreatedAt = now,
                UpdatedAt = now
            },
            new Ticket
            {
                Id = 5,
                ScreeningId = 5,
                CustomerId = 5,
                NumSeats = 2,
                CreatedAt = now,
                UpdatedAt = now
            }
        };
    }
}
