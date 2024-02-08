using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

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
        public string Phone { get; set; }

        [Column("date_created")] 
        public DateTime TimeCreated { get; set; }

        [Column("date_updated")]
        public DateTime TimeUpdated { get; set; }
        
        [JsonIgnore]
        [Column("tickets")] 
        public List<Ticket> Tickets { get; set; }
    }
}
