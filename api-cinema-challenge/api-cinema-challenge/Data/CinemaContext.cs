using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string dateString = "2023-03-14T11:01:56.633+00:00";
            DateTimeOffset dateTime = DateTimeOffset.Parse(dateString);
            DateTime dateTimeUtc = dateTime.UtcDateTime;

            

            //Primary Composite key for ticket
            //Alternate keys for tickets
           
            modelBuilder.Entity<Ticket>().HasKey(e => new {e.screeningId, e.seatId} );
            modelBuilder.Entity<Ticket>().HasAlternateKey(e => e.Id);
            modelBuilder.Entity<Ticket>().Property(e => e.Id).ValueGeneratedOnAdd();


            //Add test data
            Seeder.Seed(modelBuilder);



        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking > Bookings { get; set; }
        public DbSet<Screen> Screens{ get; set; }
        public DbSet<Seat> Seats{ get; set; }
        //public DbSet<SeatScreening> SeatScreenings{ get; set; }
        public DbSet<Ticket> Tickets{ get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }

    }
}
