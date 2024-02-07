using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Data;

namespace api_cinema_challenge.Models
{
    [Table("customer_ticket")]
    public class CustomerTicket
    {
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer {get; set;}
        [Column("ticket_id")]
        public int TicketId {get; set;}
        public Ticket Ticket {get; set;}

    }
}