using api_cinema_challenge.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket : DbEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("number_of_seats")]
        public int NumSeats { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
