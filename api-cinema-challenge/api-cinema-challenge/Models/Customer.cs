using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{

    [Table("customers")]
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public string UserId { get; set; }

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
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }


        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
