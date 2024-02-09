using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Reflection.Metadata;
using api_cinema_challenge.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
           
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            //PrimaryKeys
            modelBuilder.Entity<Customer>().HasKey(c => c.Id).HasAnnotation(DatabaseGeneratedOption.Identity.ToString(), 1);
            modelBuilder.Entity<Ticket>().HasKey(t => new{t.ScreeningId,t.CustomerId });
            modelBuilder.Entity<Screening>().HasKey(s => s.Id);
            modelBuilder.Entity<Movie>().HasKey(m => m.Id);
            
            //Timestamps
            modelBuilder.Entity<Customer>().Property(c => c.CreatedAt).HasAnnotation(DatabaseGeneratedOption.Identity.ToString(), DateTime.UtcNow);
            modelBuilder.Entity<Movie>().Property(c => c.CreatedAt).HasAnnotation(DatabaseGeneratedOption.Identity.ToString(), DateTime.UtcNow);
            modelBuilder.Entity<Screening>().Property(c => c.CreatedAt).HasAnnotation(DatabaseGeneratedOption.Identity.ToString(), DateTime.UtcNow);
            modelBuilder.Entity<Ticket>().Property(c => c.CreatedAt).HasAnnotation(DatabaseGeneratedOption.Identity.ToString(), DateTime.UtcNow);

            modelBuilder.Entity<Customer>().Property(c => c.UpdatedAt).HasAnnotation(DatabaseGeneratedOption.Computed.ToString(), DateTime.UtcNow);
            modelBuilder.Entity<Movie>().Property(c => c.UpdatedAt).HasAnnotation(DatabaseGeneratedOption.Computed.ToString(), DateTime.UtcNow);
            modelBuilder.Entity<Screening>().Property(c => c.UpdatedAt).HasAnnotation(DatabaseGeneratedOption.Computed.ToString(), DateTime.UtcNow);
            modelBuilder.Entity<Ticket>().Property(c => c.UpdatedAt).HasAnnotation(DatabaseGeneratedOption.Computed.ToString(), DateTime.UtcNow);

            // Many-To-Many relations
            modelBuilder.Entity<Customer>().HasMany(c => c.Tickets).WithOne(t=>t.Customer).HasForeignKey(t => t.CustomerId);
            modelBuilder.Entity<Screening>().HasMany( s => s.Tickets).WithOne(s=>s.Screening).HasForeignKey(s => s.ScreeningId);
            modelBuilder.Entity<Movie>().HasMany(m => m.Screenings).WithOne(s=>s.Movie).HasForeignKey(s => s.MovieId);

            //seeding
            //Customer
         
            Customer customer = new Customer() { Id = 1, Name = "Oscar Olsson", Email = "Oscar@Olsson.com", Phone = "09876543", UpdatedAt= DateTime.UtcNow };
            modelBuilder.Entity<Customer>().HasData(customer);
            
            //Movie entites
         
            Movie movie = new Movie() { Id = 1, Title = "Empty Relations", Rating = 3, Description = "Horror movie by famous programmer Steven", RunTime = 124 };
            modelBuilder.Entity<Movie>().HasData(movie);
            modelBuilder.Entity<Movie>().HasData(new Movie() { Id = 2, Title = "Empty Relations 2", Rating = 5, Description = "Follow up from Steven", RunTime = 124 });

            //Screening
         
            Screening screening = new Screening() {Id=1, ScreenNumber = 2, Capacity = 320, StartsAt = new DateTime(2024, 04, 10, 08, 10, 00, DateTimeKind.Utc), MovieId = 1 };
            modelBuilder.Entity<Screening>().HasData(screening);

            //Ticket
             modelBuilder.Entity<Ticket>().HasData(new Ticket() { CustomerId = 1, ScreeningId = 1, NumSeats = 3 });
           
        }

 
       public DbSet<Movie> Movies { get; set; }
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Screening> Screenings { get; set; }
       public DbSet<Ticket> Tickets { get; set; }
        
    }
}
