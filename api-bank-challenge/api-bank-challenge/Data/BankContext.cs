using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using BankApp.Models;

namespace BankApp.Data
{
    public class BankContext : DbContext
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

        public DbSet<User> Users{ get; set; }
        public DbSet<Account> Accounts{ get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
