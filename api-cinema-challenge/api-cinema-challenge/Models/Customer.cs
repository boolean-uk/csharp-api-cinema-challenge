using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Customer : BaseEntity
    {

        [Column("name")]
        public string Name { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("screenings")]

        public ICollection<Ticket> Tickets { get; set; }

    }
}
