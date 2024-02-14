using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;

namespace api_cinema_challenge.Models.DTO.Entities.SalesAndTickets
{
    public class ScreeningSeatOutputDTO
    {
        public ScreeningSeatOutputDTO(ScreeningSeat seat)
        {
            RowNumber = seat.Seat.RowNumber;
            SeatNumber = seat.Seat.SeatNumber;
        }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
    }
}
