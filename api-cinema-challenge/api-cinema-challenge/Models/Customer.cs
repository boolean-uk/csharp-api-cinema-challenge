using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int Id { get; set; }

        [Column("customer_name")]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        [Column("customer_email")]
        public string Email { get; set; } = string.Empty;

        [Column("customer_phone")]
        public string Phone { get; set; } = string.Empty;

        [Column("customer_createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("customer_updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("tickets")]
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
