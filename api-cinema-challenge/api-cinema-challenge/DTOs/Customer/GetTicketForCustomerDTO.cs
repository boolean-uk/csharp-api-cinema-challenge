namespace api_cinema_challenge.DTOs.Customer
{
    public class GetTicketForCustomerDTO
    {
        public int Id { get; set; }
        public int ScreeningId { get; set; }
        public int ScreenNumber { get; set; }
        public int NumSeats { get; set; }
        public string MovieTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
