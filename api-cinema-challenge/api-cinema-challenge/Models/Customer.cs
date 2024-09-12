using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("Updated A")]
        public DateTime UpdatedAt { get; set; }

        public Customer(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            CreatedAt = DateTime.Now.ToUniversalTime();
            UpdatedAt = DateTime.Now.ToUniversalTime();
        }
    }
}
