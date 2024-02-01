 namespace api_cinema_challenge.Models
{
    public class SeatScreen
    {

        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        
    }
}