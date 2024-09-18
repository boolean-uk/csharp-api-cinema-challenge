using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AddTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseClass && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.Now.ToUniversalTime();

                if (entity.State == EntityState.Added)
                {
                    ((BaseClass)entity.Entity).CreatedAt = now;
                }
                ((BaseClass)entity.Entity).UpdatedAt = now;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Primary Keys
            modelBuilder.Entity<Customer>().HasKey(x => x.Id);
            modelBuilder.Entity<Movie>().HasKey(x => x.Id);
            modelBuilder.Entity<Screening>().HasKey(x => x.Id);
            modelBuilder.Entity<Ticket>().HasKey(x => x.Id);

            // Seed data:
            List<Customer> customers = new List<Customer>()
            {
                new Customer
            {
                Id = 1,
                Name = "Audrey Hepburn",
                Email = "audrey.hepburn@example.com",
                Phone = "+47 12345678",
                CreatedAt = new DateTime(2024, 1, 15).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 2,
                Name = "Donald Trump",
                Email = "donald.trump@example.com",
                Phone = "+47 23456789",
                CreatedAt = new DateTime(2024, 2, 20).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 3,
                Name = "Elvis Presley",
                Email = "elvis.presley@example.com",
                Phone = "+47 34567890",
                CreatedAt = new DateTime(2024, 3, 25).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 4,
                Name = "Barack Obama",
                Email = "barack.obama@example.com",
                Phone = "+47 45678901",
                CreatedAt = new DateTime(2024, 4, 10).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 5,
                Name = "Oprah Winfrey",
                Email = "oprah.winfrey@example.com",
                Phone = "+47 56789012",
                CreatedAt = new DateTime(2024, 5, 5).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 6,
                Name = "Jimi Hendrix",
                Email = "jimi.hendrix@example.com",
                Phone = "+47 67890123",
                CreatedAt = new DateTime(2024, 6, 15).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 7,
                Name = "Mick Jagger",
                Email = "mick.jagger@example.com",
                Phone = "+47 78901234",
                CreatedAt = new DateTime(2024, 7, 20).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 8,
                Name = "Kate Winslet",
                Email = "kate.winslet@example.com",
                Phone = "+47 89012345",
                CreatedAt = new DateTime(2024, 8, 25).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 9,
                Name = "Charles Windsor",
                Email = "charles.windsor@example.com",
                Phone = "+47 90123456",
                CreatedAt = new DateTime(2024, 9, 5).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            },
                new Customer
            {
                Id = 10,
                Name = "Kate Middleton",
                Email = "kate.middleton@example.com",
                Phone = "+47 01234567",
                CreatedAt = new DateTime(2024, 9, 10).ToUniversalTime(),
                UpdatedAt = new DateTime(2024, 9, 12).ToUniversalTime()
            }};
            modelBuilder.Entity<Customer>().HasData(customers);
        }
        public DbSet<Customer> Customers { get; set; }

    }
}
