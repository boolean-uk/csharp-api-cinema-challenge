using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Reflection.Metadata;
using api_cinema_challenge.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
           
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().Property(m => m.CreatedAt).ValueGeneratedOnAdd();
            modelBuilder.Entity<Movie>().Property(m => m.UpdatedAt).ValueGeneratedOnAddOrUpdate().Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            modelBuilder.Entity<Movie>().Property(m => m.UpdatedAt).ValueGeneratedOnAdd();
            modelBuilder.Entity<Movie>().HasData(new Movie() { Id = 1, Title = "Empty Relations", Description = "Horror movie by famous programmer Steven", Rating = 3, RunTime = 124 });

        }

       // public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        //public DbSet<Screening> Screenings { get; set; }
        //public DbSet<Ticket> Tickets { get; set; }
        
    }
}
