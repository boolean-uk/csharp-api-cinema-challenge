using System.ComponentModel.DataAnnotations.Schema;


namespace api_cinema_challenge.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Phone")]
        public string Phone { get; set; }
        [Column("CreatedAt")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        [Column("UpdatedAt")]
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}
