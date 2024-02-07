using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("custommer")]
    public class Custommer
    {
        [Key]
        [Column("custommer_id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("created_at", TypeName = "Date")]
        public DateTime CreatedAt { get; set;}

        [Column("updated_at", TypeName = "Date")]
        public DateTime? UpdatedAt { get; set;}

        [Column("tickets")]
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
