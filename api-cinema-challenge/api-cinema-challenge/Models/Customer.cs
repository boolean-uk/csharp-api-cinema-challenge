using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string name { get; set; }
        [Required]
        [Column("email")]
        public string email { get; set; }
        [Required]
        [Column("phone")]
        public string phone { get; set; }
        [Column("createdAt", TypeName = "timestamp")]
        public DateTime createdAt { get; set; } = DateTime.Now;
        [Column("updatedAt", TypeName = "timestamp")]
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public List<Ticket> tickets { get; set; }
    }
}
