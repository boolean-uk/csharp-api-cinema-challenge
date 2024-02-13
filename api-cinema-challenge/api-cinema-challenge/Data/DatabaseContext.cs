using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class DatabaseContext : DbContext
    {
        private string _connectionString;
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
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
            modelBuilder.Entity<Ticket>()
                .HasKey(t => new { t.FkCustomerId, t.FkScreeningId });

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.FkCustomerId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Screening)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.FkScreeningId);
        }
    }
}
