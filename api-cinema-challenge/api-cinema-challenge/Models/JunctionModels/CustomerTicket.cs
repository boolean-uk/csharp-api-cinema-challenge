using api_cinema_challenge.Models.PureModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.JunctionModels
{
    [Table("customer_tickets")]
    public class CustomerTicket
    {
        [Column("customer_id")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Column("ticket_id")]
        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }
    }
}
