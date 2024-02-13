using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class SeatDto
    {
        public string HallName { get; set; }
        public string SeatRow { get; set; }
        public int SeatNumber { get; set; }

        public SeatDto(Seat seat)
        {
            //Async issue; Nigel please fix if you have time :)
            if(seat == null)
            {
                HallName = "Seat is null error";
                SeatRow = "Seat is null error";
                SeatNumber = 0;
            } else
            {
                HallName = seat.Hall.HallName;
                SeatRow = seat.SeatRow;
                SeatNumber = seat.SeatNumber;
            }
            
        }

        public SeatDto()
        {
            
        }
    }
}
