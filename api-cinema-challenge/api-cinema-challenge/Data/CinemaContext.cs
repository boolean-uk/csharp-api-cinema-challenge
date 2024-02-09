using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Screenings)
                .WithOne(e => e.Movie)
                .HasForeignKey(e => e.MovieId)
                .IsRequired();
            modelBuilder.Entity<Screening>()
                .HasOne(e => e.Movie)
                .WithMany()
                .HasForeignKey(e => e.MovieId)
                .IsRequired();

            modelBuilder.Entity<Screening>()
                .Navigation(e => e.Movie).AutoInclude();
           

            modelBuilder.Entity<Customer>()
                .HasData(seeder.Customers);
            modelBuilder.Entity<Movie>()
                .HasData(seeder.Movies);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}
