using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Context
{
    public class CinemaContext : DbContext
    {
        private static string GetConnectionString()
        {
            string jsonSettings = File.ReadAllText("appsettings.json");
            JObject configuration = JObject.Parse(jsonSettings);
            return configuration["ConnectionStrings"]["DefaultConnectionString"].ToString();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(GetConnectionString());
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Screenings> Screenings { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
