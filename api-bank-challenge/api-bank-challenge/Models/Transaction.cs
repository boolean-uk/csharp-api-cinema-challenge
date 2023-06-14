using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Ammount { get; set; }
        public string Type { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
    }
}
