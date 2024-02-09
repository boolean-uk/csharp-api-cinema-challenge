using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
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
           // this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Customer model
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");
                entity.HasKey(e => e.Id).HasName("customer_id");
                entity.Property(e => e.Id).HasColumnName("customer_id");
                entity.Property(e => e.CustomerName).HasColumnName("customer_name");
                entity.Property(e => e.EmailAdress).HasColumnName("email_adr");
                entity.Property(e => e.PhoneNumber).HasColumnName("phone_nr");
                entity.Property(e => e.CreatedAt).HasColumnName("created_at");
                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            // Configure the Movie model
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");
                entity.HasKey(e => e.MovieId).HasName("movie_id");
                entity.Property(e => e.MovieId).HasColumnName("movie_id");
                entity.Property(e => e.Title).HasColumnName("movie_title");
                entity.Property(e => e.Rating).HasColumnName("movie_rating");
                entity.Property(e => e.Description).HasColumnName("movie_description");
                entity.Property(e => e.RuntimeMins).HasColumnName("movie_runtimeMins");
                entity.Property(e => e.CreatedAt).HasColumnName("created_at");
                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
                entity.HasMany(e => e.Screenings);
            });

            // Configure the Screening model
            modelBuilder.Entity<Screening>(entity =>
            {
                entity.ToTable("screenings");
                entity.HasKey(e => e.ScreeningId).HasName("screen_id");
                entity.Property(e => e.ScreeningId).HasColumnName("screen_id");
                entity.Property(e => e.ScreenNumber).HasColumnName("screen_number");
                entity.Property(e => e.ScreenCapacity).HasColumnName("screen_capacity");
                entity.Property(e => e.StartsAt).HasColumnName("starts_at");
                entity.Property(e => e.CreatedAt).HasColumnName("created_at");
                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
                entity.Property(e => e.MovieId).HasColumnName("fk_movie_id");
            });

        

            modelBuilder.Entity<Customer>().HasData(Seeder.GetCustomers());
            modelBuilder.Entity<Movie>().HasData(Seeder.GetMovies());
            modelBuilder.Entity<Screening>().HasData(Seeder.GetScreenings());

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
