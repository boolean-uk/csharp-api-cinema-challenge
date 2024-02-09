using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("customer")]
    [PrimaryKey("Id")]
    public class Customer
    {
        [Column("customer_id")]
        public int Id { get; set; }
        [Column("customer_name")]
        public string Name { get; set; }
        [Column("customer_email")]
        public string Email { get; set; }
        [Column("customer_phone")]
        public string Phone { get; set; }
        [Column("customer_created_date")]
        public DateTime CreatedAt { get; set; }
        [Column("customer_updated_date")]
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        public ICollection<Ticket> Tickets { get; set; }
    }
}
