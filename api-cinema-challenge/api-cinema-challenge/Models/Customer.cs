using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("names")]
        public string Name { get; set; }
        [Column("emails")]
        public string Email { get; set; }
        [Column("phoneNumbers")]
        public string Phone { get; set; }
        [Column("createdAt")]
        public DateTime createdAt { get; set; }
        [Column("updatedAt")]
        public DateTime updatedAt { get; set; } 
        
        public List<Ticket> Tickets { get; set; }
    }
}
