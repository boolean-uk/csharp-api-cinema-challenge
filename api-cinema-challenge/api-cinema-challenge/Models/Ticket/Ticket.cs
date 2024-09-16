using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Ticket
{
    [Table("TICKET")]
    public class Ticket
    {
        [Key] 
        [Required]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMSEATS")]
        public int numSeats { get; set; }
        [Column("CREATEDAT")]
        public DateTime createdAt { get; set; }
        [Column("UPDATEDAT")]
        public DateTime updatedAt { get; set; }
    }
}
