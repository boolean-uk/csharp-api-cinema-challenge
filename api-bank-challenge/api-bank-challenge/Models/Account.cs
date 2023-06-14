using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int Balance { get; set; }
        public List<Transaction> transactions { get; set; } = new List<Transaction>();

        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
