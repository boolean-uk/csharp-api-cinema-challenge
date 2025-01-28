using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public Customer customer { get; set; }
        public int numSeats {  get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        [ForeignKey("Screening")]
        public Screening screening { get; set; }
    }
}
