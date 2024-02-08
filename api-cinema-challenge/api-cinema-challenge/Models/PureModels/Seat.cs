using api_cinema_challenge.Models.JunctionModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.PureModels
{
    [Table("seats")]
    public class Seat
    {
        [Column("seat_id")]
        public int SeatId { get; set; }

        public TicketSeat Ticket { get; set; }

        [Column("display_id")]
        [ForeignKey("DisplayId")]
        public int DisplayId { get; set; }

        public Display Display { get; set; }

        [Column("row_number")]
        public int RowNumber { get; set; }

        [Column("seat_number")]
        public int SeatNumber { get; set; }
    }
}
