using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.CustomerModels
{
    [Table("customer")]
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("name")]
        public required string Name { get; set; }

        [Column("phone")]
        public required string Phone { get; set; }

        [Column("email")]
        public required string Email { get; set; }
    }
}
