using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {
    public class SeatDTO {
        public string SeatRow {get; set;}
        public int SeatNumber {get; set;}


        public SeatDTO(Seat seat) {
            SeatRow = seat.SeatRow;
            SeatNumber = seat.SeatNumber;
        }

        public static List<SeatDTO> FromRepository(ICollection<Seat> seats) {
            List<SeatDTO> ret = new List<SeatDTO>();
            foreach (Seat seat in seats)
            {
                ret.Add(new SeatDTO(seat));
            }
            return ret;
        }
    }
}