using api_cinema_challenge.Models.Base;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class DataContext : DbContext
    {
        private string _connectionString;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Phone).IsRequired().HasMaxLength(50);
                entity.Property(e => e.CreatedAt);
                entity.Property(e => e.UpdatedAt);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Rating).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.RuntimeMins).IsRequired();
                entity.Property(e => e.CreatedAt).ValueGeneratedOnAdd();
                entity.Property(e => e.UpdatedAt).ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Screening>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ScreenNumber).IsRequired();
                entity.Property(e => e.Capacity).IsRequired();
                entity.Property(e => e.StartsAt).IsRequired();
                entity.Property(e => e.CreatedAt).ValueGeneratedOnAdd();
                entity.Property(e => e.UpdatedAt).ValueGeneratedOnAddOrUpdate();
                entity.HasOne(e => e.Movie)
                      .WithMany(m => m.Screenings)
                      .HasForeignKey(e => e.MovieId);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ScreeningId });
                entity.Property(e => e.NumSeats).IsRequired();
                entity.Property(e => e.CreatedAt);
                entity.Property(e => e.UpdatedAt);
                entity.HasOne(e => e.Customer)
                      .WithMany(c => c.Tickets)
                      .HasForeignKey(e => e.CustomerId);
                entity.HasOne(e => e.Screening)
                      .WithMany(s => s.Tickets)
                      .HasForeignKey(e => e.ScreeningId);
            });
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
