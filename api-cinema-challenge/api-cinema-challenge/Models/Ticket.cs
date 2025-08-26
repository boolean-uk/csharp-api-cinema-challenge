using api_cinema_challenge.DOTs.TicketDTO;
using api_cinema_challenge.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("ticket_id")]
        public int Id { get; set; }
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("ticket_screening")]
        public Screening Screening { get; set; }

        [Column("ticket_customer")]
        public Customer Customer { get; set; }
        public int numSeats { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt {  get; set; }

        public Ticket(TicketPost ticket, int screeningId, int customerId)
        {
            ScreeningId = screeningId;
            CustomerId = customerId;
            numSeats = ticket.numSeats;
        }
        public Ticket()
        {
            
        }
    }
}
