using System.ComponentModel.DataAnnotations.Schema;


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
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("created_time")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_time")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
