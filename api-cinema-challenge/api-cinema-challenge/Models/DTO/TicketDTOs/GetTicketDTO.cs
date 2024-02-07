namespace api_cinema_challenge.Models.DTO.TicketDTOs
{
    public class GetTicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
