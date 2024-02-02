using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Models;

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
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Seeder seeder = new Seeder();

            modelBuilder.Entity<Ticket>().HasKey(e => new { e.Id, e.ScreeningId, e.CustomerId });

            modelBuilder.Entity<Movie>().HasMany(e => e.Screenings).WithOne(e => e.Movie).HasForeignKey(e => e.MovieId);



            modelBuilder.Entity<Movie>().HasData(seeder.Movies);

            modelBuilder.Entity<Customer>().HasData(seeder.Customers);

            modelBuilder.Entity<Screening>().HasData( seeder.Screenings );

            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
