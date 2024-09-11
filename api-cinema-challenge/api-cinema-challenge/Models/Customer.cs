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
        [Column("createdAt")]
        public DateTime CreatedAt {  get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
