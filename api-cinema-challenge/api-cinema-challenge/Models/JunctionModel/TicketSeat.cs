using api_cinema_challenge.Models.PureModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.JunctionModel
{
    [Table("ticket_seat")]
    public class TicketSeat
    {
        [Column("seat_id")]
        [ForeignKey("SeatId")]
        public int SeatId { get; set; }

        public Seat Seat { get; set; }

        [Column("display_id")]
        [ForeignKey("DisplayId")]
        public int DisplayId { get; set; }

        public Display Display { get; set; }

        [Column("ticket_id")]
        [ForeignKey("TicketId")]
        public int TicketId { get; set; }

        public Ticket Ticket { get; set; }
    }
}
