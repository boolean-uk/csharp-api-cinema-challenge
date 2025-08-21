using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Model {

    public class Seat {
        public int Id {get; set;}
        public required string SeatRow {get; set;}
        public required int SeatNumber {get; set;}
        public int ScreeningId {get; set;}
        public Screening Screening {get; set;} = null!;
        public int? TicketId {get; set;}
        public Ticket Ticket {get; set;} = null!;
    }
}