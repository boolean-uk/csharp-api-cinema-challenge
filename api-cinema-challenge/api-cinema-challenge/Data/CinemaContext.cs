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
        }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Screening> Screenings => Set<Screening>();
        public DbSet<Ticket> Tickets => Set<Ticket>(); 
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // UTC timestamptz for tracked timestamps
            modelBuilder.Entity<Customer>().Property(p => p.CreatedAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Customer>().Property(p => p.UpdatedAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Movie>().Property(p => p.CreatedAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Movie>().Property(p => p.UpdatedAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Screening>().Property(p => p.StartsAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Screening>().Property(p => p.CreatedAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Screening>().Property(p => p.UpdatedAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Ticket>().Property(p => p.CreatedAt).HasColumnType("timestamptz");
            modelBuilder.Entity<Ticket>().Property(p => p.UpdatedAt).HasColumnType("timestamptz");

            // Screening -> Movie
            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Ticket table + relations
            modelBuilder.Entity<Ticket>().ToTable("ticket");
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany()
                .HasForeignKey(t => t.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Screening)
                .WithMany()
                .HasForeignKey(t => t.ScreeningId)
                .OnDelete(DeleteBehavior.Cascade);

            // Required fields per spec
            modelBuilder.Entity<Movie>().Property(m => m.Title).IsRequired();
            modelBuilder.Entity<Movie>().Property(m => m.Rating).IsRequired();
            modelBuilder.Entity<Movie>().Property(m => m.Description).IsRequired();
            modelBuilder.Entity<Movie>().Property(m => m.RuntimeMins).IsRequired();

            modelBuilder.Entity<Customer>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Email).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Phone).IsRequired();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var now = DateTime.UtcNow;
            foreach (var e in ChangeTracker.Entries())
            {
                if (e.State == EntityState.Added)
                {
                    if (e.Metadata.FindProperty("CreatedAt") != null) e.CurrentValues["CreatedAt"] = now;
                    if (e.Metadata.FindProperty("UpdatedAt") != null) e.CurrentValues["UpdatedAt"] = now;
                }
                else if (e.State == EntityState.Modified)
                {
                    if (e.Metadata.FindProperty("UpdatedAt") != null) e.CurrentValues["UpdatedAt"] = now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
