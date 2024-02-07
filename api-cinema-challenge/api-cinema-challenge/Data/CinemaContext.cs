using api_cinema_challenge.Models;
using exercise.webapi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Numerics;

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
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId);



            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.customerId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Screening)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.screeningId);




            Seeder seeder = new Seeder();

            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);
            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);

            //modelBuilder.Entity<Customer>().HasData(
            //   new Customer { Id = 1, Name = "Robert Ole", Email = "Robert_Ole@gmail.com", Phone = "+4748371611" },
            //   new Customer { Id = 2, Name = "Alex Adam" , Email = "Alex_Adam@gmail.com" , Phone = "+4789828277"}
            //   );


            //modelBuilder.Entity<Movie>().HasData(
            //    new Movie { Id = 1, Title = "The Brookie", 
            //        Description = " Life's too short to not follow your dream", Rating = "7", Runtime = 130 },
            //    new Movie { Id = 2, Title = "Vikings", Description = " Historica action series", Rating = "8", Runtime = 158}
            //    );


            //modelBuilder.Entity<Screening>().HasData(
            //    new Screening { Id = 1, ScreanNumber = 2, Capacity = 100, MovieId = 2, StartsAt = DateTime.UtcNow },
            //    new Screening { Id = 2, ScreanNumber = 1, Capacity = 140, MovieId = 1, StartsAt= DateTime.UtcNow }
            //    );

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
