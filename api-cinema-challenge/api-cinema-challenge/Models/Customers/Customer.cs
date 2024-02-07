using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Data;

namespace api_cinema_challenge.Models
{
    [Table("customer")]
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public int Phone { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}