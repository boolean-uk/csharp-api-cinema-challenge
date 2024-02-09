using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Text;

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
        [EmailAddress]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        [Column("updated_at")]
        public DateTime UpdatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);

        [JsonIgnore]
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

   
    }
}
