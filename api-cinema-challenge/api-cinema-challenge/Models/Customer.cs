using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("createdAt")]
        public DateTime createdAt { get; set; }
        [Column("updatedAt")]
        public DateTime updatedAt { get; set; }
    }
}
