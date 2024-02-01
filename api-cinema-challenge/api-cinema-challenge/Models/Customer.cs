using System.Net.Mail;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        [EmailAddress]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; } // (DateTime.Today.Date.ToString("dd-MM-yyyy HH:mm:ss")
        public DateTime UpdatedAT { get; set; }
    }
}
