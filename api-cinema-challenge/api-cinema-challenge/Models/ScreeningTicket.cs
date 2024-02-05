using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Data;

namespace api_cinema_challenge.Models
{
    [Table("screening_ticket")]
    public class ScreeningTicket
    {
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening {get; set;}
        [Column("ticket_id")]
        public int TicketId {get; set;}
        public Ticket Ticket {get; set;}

    }
}