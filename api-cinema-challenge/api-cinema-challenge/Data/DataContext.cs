using api_cinema_challenge.Data.SeedData;
using api_cinema_challenge.Models.JunctionModel;
using api_cinema_challenge.Models.PureModels;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public class DataContext : DbContext
    {
        private string _connectionString;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seat>().HasKey(s => new { s.SeatId, s.DisplayId});

            modelBuilder.Entity<TicketSeat>().HasKey(ts => new { ts.ScreeningId, ts.DisplayId, ts.SeatId});

            modelBuilder.Entity<TicketSeat>()
                .HasOne(ts => ts.Screening)
                .WithMany(t => t.TicketSeats)
                .HasForeignKey(ts => ts.ScreeningId);

            modelBuilder.Entity<TicketSeat>()
                .HasOne(ts => ts.Seat)
                .WithMany(s => s.Ticket)
                .HasForeignKey(ts => new { ts.SeatId, ts.DisplayId});

            modelBuilder.Entity<TicketSeat>()
                .HasOne(ts => ts.Display)
                .WithMany(d => d.Seats)
                .HasForeignKey(ts => ts.DisplayId);

            modelBuilder.Entity<Screening>().Navigation(d => d.Display).AutoInclude();
            modelBuilder.Entity<Ticket>().Navigation(t => t.Customer).AutoInclude();
            modelBuilder.Entity<TicketSeat>().Navigation(ts => ts.Seat).AutoInclude();

            // Seed data
            Seeder seeder = new Seeder();
            modelBuilder.Entity<Display>().HasData(seeder.Displays);
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);
            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);
            modelBuilder.Entity<Seat>().HasData(seeder.Seats);
            modelBuilder.Entity<TicketSeat>().HasData(seeder.TicketSeats);

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<TicketSeat> TicketSeats { get; set; }
    }
}
