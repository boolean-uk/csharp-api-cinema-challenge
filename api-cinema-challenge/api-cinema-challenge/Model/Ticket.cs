using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model
{
    [Table("tickets")]
    public class Ticket
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("num_seats")]
        public int NumSeats { get; set; }
        
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("customers_fk"), Column("customers_fk")]
        public int CustomerId { get; set; }

        [ForeignKey("screenings_fk"), Column("screenings_fk")]
        public int ScreeningsId { get; set; }
    }
}
