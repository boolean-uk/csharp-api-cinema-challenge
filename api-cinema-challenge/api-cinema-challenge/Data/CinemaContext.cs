using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using api_cinema_challenge.Seeder;

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
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            // Add many to many relationship between screening and custommer in ticket:
            //modelBuilder.Entity<Ticket>().HasKey(a => new { a.ScreeningId, a.CustommerId, a.CreatedAt });

            // Add one to many relationship between custommer and ticket:
            modelBuilder.Entity<Custommer>().HasMany(t => t.Tickets).WithOne(c => c.Custommer).HasForeignKey(t => t.CustommerId);

            //Seeding: 
            Seeders seeder = new Seeders();

            modelBuilder.Entity<Custommer>().HasData(seeder.custommers);
            modelBuilder.Entity<Movie>().HasData(seeder.movies);
            modelBuilder.Entity<Screening>().HasData(seeder.screenings);
            modelBuilder.Entity<Ticket>().HasData(seeder.tickets);

        }

        public DbSet<Custommer> Custommers { get; set;}
        public DbSet<Movie> Movies { get; set;}
        public DbSet<Screening> Screenings {  get; set;}
        public DbSet<Ticket> Tickets { get; set;}

    }
}
