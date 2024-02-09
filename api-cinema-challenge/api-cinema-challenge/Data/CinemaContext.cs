using api_cinema_challenge.Models.Types;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace api_cinema_challenge.Data;

public class CinemaContext : DbContext
{
    private string _connectionString;
    public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
        //this.Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { Id = 1, Name = "GWD", Email = "GWD@GWD.com", Phone = "+4712345678", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Customer() { Id = 2, Name = "Per", Email = "Per@Per.com", Phone = "+4787654321", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Customer() { Id = 3, Name = "Carl", Email = "Carl@Carl.com", Phone = "+4712344321", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
        });

        modelBuilder.Entity<Movie>().HasData(new List<Movie>()
        {
            new Movie()
            {
                Id = 1, Title = "Godzilla minus one", Rating = "PG-13",
                Description = "Post war Japan is at its lowest point when a new crisis emerges in the form of a giant monster, baptized in the horrific power of the atomic bomb.",
                RuntimeMins = 124, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
            new Movie()
            {
                Id = 2, Title = "Jawan", Rating = "PG-15",
                Description = "A high-octane action thriller which outlines the emotional journey of a man who is set to rectify the wrongs in the society.",
                RuntimeMins = 169, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
        });

        modelBuilder.Entity<Screening>().HasData(new List<Screening>()
        {
            new Screening()
            {
                Id = 1, MovieId = 2, Capacity = 40, ScreenNumber = 5,
                StartsAt = DateTime.SpecifyKind(new DateTime(2024, 2, 14, 18, 30, 00), DateTimeKind.Utc),
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
            new Screening()
            {
                Id = 2, MovieId = 1, Capacity = 80, ScreenNumber = 1,
                StartsAt = DateTime.SpecifyKind(new DateTime(2024, 2, 14, 18, 30, 00), DateTimeKind.Utc),
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
            new Screening()
            {
                Id = 3, MovieId = 1, Capacity = 40, ScreenNumber = 5,
                StartsAt = DateTime.SpecifyKind(new DateTime(2024, 2, 14, 21, 30, 00), DateTimeKind.Utc),
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
        });

        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>
        {
            new Ticket { Id = 1, CustomerId = 1, ScreeningId = 2, NumSeats = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new Ticket { Id = 2, CustomerId = 2, ScreeningId = 1, NumSeats = 38, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        });
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
        optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Screening> Screenings { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
