using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
        
    public class Customer : BaseEntity
    {
        
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone_number")]
        public string Phone { get; set; }

        [Column("screenings")]
        public List<Ticket> Tickets { get; set; }
    }
}
