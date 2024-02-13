using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : IdentityUserContext<ApplicationUser>
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Movie>().HasKey(m => new { m.id });
            modelBuilder.Entity<Customer>().HasKey(c => new { c.id });
            modelBuilder.Entity<Screening>().HasKey(s => new { s.id });
            modelBuilder.Entity<Ticket>().HasKey(t => new { t.id });

            modelBuilder.Entity<Movie>().HasData(seeder.movies);
            modelBuilder.Entity<Customer>().HasData(seeder.customers);
            modelBuilder.Entity<Screening>().HasData(seeder.screenings);
            modelBuilder.Entity<Ticket>().HasData(seeder.tickets);
        }


        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }









}
