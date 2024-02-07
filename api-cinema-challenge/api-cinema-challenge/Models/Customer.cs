using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("email")]
        [Required]
        public string Email { get; set; }

        [Column("phone")]
        [Required]
        public string Phone { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
