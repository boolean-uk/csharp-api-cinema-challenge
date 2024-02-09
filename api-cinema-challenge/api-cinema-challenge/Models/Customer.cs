using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int Id { get; internal set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string PhoneNumber { get; set; }
        [Column("createdAt")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
        [Column("UpdatedAt")]
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }
    }
}
