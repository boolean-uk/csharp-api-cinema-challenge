using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.DataContext
{
    public class CinemaContext : DbContext
    {
        private string connectionString;

        public CinemaContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}