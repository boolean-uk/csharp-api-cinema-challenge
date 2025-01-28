using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace api_cinema_challenge.Data;

public class CinemaContext : DbContext
{
    private readonly string _connectionString;

    public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
        //this.Database.EnsureCreated();
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Screening> Screenings { get; set; }
    public DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Screening>().HasOne(s => s.Movie).WithMany(m => m.Screenings).HasForeignKey(s => s.MovieId);
        modelBuilder.Entity<Ticket>().HasOne(t => t.Customer).WithMany(c => c.Tickets).HasForeignKey(t => t.CustomerId);
        modelBuilder.Entity<Ticket>().HasOne(t => t.Screening).WithMany(s => s.Tickets).HasForeignKey(t => t.ScreeningId);
        
        modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                Id = 1, Name = "John Doe", Email = "john's email", Phone = "john's phone", CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Customer
            {
                Id = 2, Name = "Jane Doe", Email = "jane's email", Phone = "jane's phone", CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        );

        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1, Title = "The Godfather", Rating = "", Description = "", RuntimeMins = 126,
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
            new Movie
            {
                Id = 2, Title = "The Shawshank Redemption", Rating = "", Description = "", RuntimeMins = 126,
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            }
        );

        modelBuilder.Entity<Screening>().HasData(
            new Screening
            {
                Id = 1, ScreenNumber = 1, Capacity = 100, StartsAt = DateTime.UtcNow, MovieId = 1,
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
            new Screening
            {
                Id = 2, ScreenNumber = 2, Capacity = 100, StartsAt = DateTime.UtcNow, MovieId = 2,
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            }
        );
        
        modelBuilder.Entity<Ticket>().HasData(
            new Ticket
            {
                Id = 1, CustomerId = 1, ScreeningId = 1, NumSeats = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            },
            new Ticket
            {
                Id = 2, CustomerId = 2, ScreeningId = 2, NumSeats = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            }
        );
    }

    public override int SaveChanges()
    {
        AddTimestamps();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        AddTimestamps();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void AddTimestamps()
    {
        var entities = ChangeTracker.Entries()
            .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

        foreach (var entity in entities)
        {
            var now = DateTime.UtcNow;

            Console.WriteLine(entity.State.ToString());
            if (entity.State == EntityState.Added) ((BaseEntity)entity.Entity).CreatedAt = now;

            if (entity.State == EntityState.Modified) ((BaseEntity)entity.Entity).UpdatedAt = now;
        }
    }
}