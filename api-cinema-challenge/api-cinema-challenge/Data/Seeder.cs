using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private ModelBuilder _modelBuilder;
        public Seeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        public void CreateCustomers()
        {
            _modelBuilder.Entity<Customer>().HasData
                (new List<Customer>() {

                    new Customer() {
                        Id = 1,
                        CreatedAt = DateTime.UtcNow, 
                        UpdatedAt = DateTime.UtcNow,
                        Email = "First.Name@email.provider",
                        Name = "First Name", 
                        Phone = "+01 012 34 567"
                    },
                    new Customer()
                    {
                        Id = 2,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Email = "Second.Name@email.provider",
                        Name = "Second Name",
                        Phone = "+01 112 34 567"
                    },
                    new Customer()
                    {
                        Id = 3,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Email = "Third.Name@email.provider",
                        Name = "Third Name",
                        Phone = "+01 122 34 567"
                    }
                }
                );
        }

        public void CreateMovies()
        {
            _modelBuilder.Entity<Movie>().HasData
                (new List<Movie>() {
                    new Movie()
                    {
                        Id = 1,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        RuntimeMins = 124,
                        Description = "description",
                        Title = "title", 
                        Rating = "PG-13"
                    },
                    new Movie()
                    {
                        Id = 2,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        RuntimeMins = 60,
                        Description = "Another description",
                        Title = "title1", 
                        Rating = "PG-14"
                    },
                    new Movie()
                    {
                        Id = 3,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        RuntimeMins = 460,
                        Description = "Yet another description",
                        Title = "title2", 
                        Rating = "PG-18"
                    }
                }
                );
        }
        public void CreateScreenings()
        {
            _modelBuilder.Entity<Screening>().HasData
                (new List<Screening>() {
                    new Screening()
                    {
                        Id = 1,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Capacity = 1,
                        ScreenNumber = 1,
                        MovieId = 1,
                        StartsAt = new DateTime(2024, 02, 09, 20, 00, 00, DateTimeKind.Utc)
                    },
                    new Screening()
                    {
                        Id = 2,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Capacity = 1,
                        ScreenNumber = 1,
                        MovieId = 2,
                        StartsAt = new DateTime(2024, 02, 11, 20, 00, 00, DateTimeKind.Utc)
                    },
                    new Screening()
                    {
                        Id = 3,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Capacity = 1,
                        ScreenNumber = 1,
                        MovieId = 3,
                        StartsAt = new DateTime(2024, 02, 15, 20, 00, 00, DateTimeKind.Utc)
                    }
                }
                );
        }
    }
}
