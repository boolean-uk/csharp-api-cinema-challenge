using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string? Name { get; set; }

        [Required]
        [Column("email")]
        public string? Email { get; set; }

        [Required]
        [Column("phone")]
        public string? Phone { get; set; }

        [Required]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }
    }
}
