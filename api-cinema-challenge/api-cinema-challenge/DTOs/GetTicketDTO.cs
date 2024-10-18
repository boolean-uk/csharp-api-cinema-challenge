namespace api_cinema_challenge.DTOs
{
    public class GetTicketDTO
    {

        public int id { get; set; }

        public int numberOfSeats { get; set; }

        public DateTime createdAt { get; set; } 

        public DateTime updatedAt { get; set; }

    }
}
