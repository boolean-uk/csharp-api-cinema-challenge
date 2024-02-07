using api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure;
using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Junctions
{
    [Table("ticket_seats")]
    public class TicketSeat
    {
        [Column("ticket_id")]
        [ForeignKey("TicketId")]
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        [Column("seat_id")]
        [ForeignKey("SeatId")]
        public int SeatId { get; set; }
        public AuditoriumSeat Seat { get; set; }
    }
}
