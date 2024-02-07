namespace api_cinema_challenge.Model.DTOs
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        public int NumberOfSeats { get; set; }
        public List<int> SeatIds { get; set; }
    }
}
