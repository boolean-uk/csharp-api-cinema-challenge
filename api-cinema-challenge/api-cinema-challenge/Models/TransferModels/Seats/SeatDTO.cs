namespace api_cinema_challenge.Models.TransferModels.Seats
{
    public class SeatDTO(int RowNumber, int SeatNumber)
    {
        public int Row { get; set; } = RowNumber;

        public int SeatNumber { get; set;} = SeatNumber;
    }
}
