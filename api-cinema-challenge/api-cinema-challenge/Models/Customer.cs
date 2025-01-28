using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Tags("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Name")]
        public string Name { get; set; }
        [Required]
        [Column("Email")]
        public string Email { get; set; }
        [Required]
        [Column("Phone")]
        public string Phone { get; set; }

        [Required]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }

    }
}
