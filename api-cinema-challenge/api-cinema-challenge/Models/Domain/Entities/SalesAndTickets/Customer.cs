using api_cinema_challenge.Models.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.SalesAndTickets
{
    [Table("customers")]
    public class Customer : ICreatedAndUpdatedTimeStamping
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("age")]
        public int Age { get; set; }

        [Column("weight_in_kg")]
        public int Weight { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        ICollection<Ticket> Tickets { get; set; }
    }
}
