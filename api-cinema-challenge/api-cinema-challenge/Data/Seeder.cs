using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            DateTime timeNow = DateTime.UtcNow;

            // Seed data for Customer
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "John Doe", Email = "john.doe@example.com", Phone = "123-456-7890", CreatedAt = timeNow, UpdatedAt = timeNow },
                new Customer { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Phone = "098-765-4321", CreatedAt = timeNow, UpdatedAt = timeNow },
                new Customer { Id = 3, Name = "Alice Johnson", Email = "alice.johnson@example.com", Phone = "123-555-7890", CreatedAt = timeNow, UpdatedAt = timeNow }
                // Add more Customer entries as needed
            );

            // Seed data for Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "The Great Adventure", Director = "Alice Jones", Description = "An epic adventure.", Rating = "PG", Runtime = new DateTime(2024, 1, 2, 2, 0, 0, DateTimeKind.Utc), ReleaseDate = DateTime.SpecifyKind(new DateTime(2024, 12, 15), DateTimeKind.Utc), CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Id = 2, Title = "Space Odyssey", Director = "Chris Nolan", Description = "A journey through space.", Rating = "PG-13", Runtime = new DateTime(2024, 1, 2, 2, 30, 0, DateTimeKind.Utc), ReleaseDate = DateTime.SpecifyKind(new DateTime(2023, 11, 22), DateTimeKind.Utc), CreatedAt = timeNow, UpdatedAt = timeNow }
                // Add more Movie entries as needed
            );

            // Seed data for Screen
            modelBuilder.Entity<Screen>().HasData(
                new Screen { id = 1, name = "Screen 1", CreatedAt = timeNow, UpdatedAt = timeNow },
                new Screen { id = 2, name = "Screen 2", CreatedAt = timeNow, UpdatedAt = timeNow }
                // Add more Screen entries as needed
            );

            // Seed data for Seat
            modelBuilder.Entity<Seat>().HasData(
                new Seat { Id = 1, ScreenId = 1, seatNumber = 1, rowNumber = 1, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Seat { Id = 2, ScreenId = 1, seatNumber = 2, rowNumber = 1, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Seat { Id = 3, ScreenId = 1, seatNumber = 3, rowNumber = 2, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Seat { Id = 4, ScreenId = 1, seatNumber = 4, rowNumber = 2, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Seat { Id = 5, ScreenId = 2, seatNumber = 1, rowNumber = 1, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Seat { Id = 6, ScreenId = 2, seatNumber = 2, rowNumber = 1, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Seat { Id = 7, ScreenId = 2, seatNumber = 3, rowNumber = 2, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Seat { Id = 8, ScreenId = 2, seatNumber = 4, rowNumber = 2, CreatedAt = timeNow, UpdatedAt = timeNow }
                // Add more Seat entries as needed
            );

            // Seed data for Screening
            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1, MovieId = 1, ScreenId = 1, StartsAt = timeNow.AddHours(3), CreatedAt = timeNow, UpdatedAt = timeNow },
                new Screening { Id = 2, MovieId = 2, ScreenId = 2, StartsAt = timeNow.AddHours(5), CreatedAt = timeNow, UpdatedAt = timeNow }
                // Add more Screening entries as needed
            );

            // Seed data for Booking
            modelBuilder.Entity<Booking>().HasData(
                new Booking { Id = 1, CustomerId = 1, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Booking { Id = 2, CustomerId = 2, CreatedAt = timeNow, UpdatedAt = timeNow }
                // Add more Booking entries as needed
            );

            // Seed data for Ticket
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { Id = 1, screeningId = 1, seatId = 1, bookingId = 1, price = 12.50f, createdAt = timeNow, updatedAt = timeNow },
                new Ticket { Id = 2, screeningId = 1, seatId = 2, bookingId = null, price = 12.50f, createdAt = timeNow, updatedAt = timeNow }, // Unbooked ticket
                new Ticket { Id = 3, screeningId = 2, seatId = 1, bookingId = 2, price = 15.00f, createdAt = timeNow, updatedAt = timeNow }
            );
        }
    }
}
