using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Responses
{
    public class TicketResponseDto : BaseEntity
    {
        public int Id { get;set; }
        public int NumberOfSeats { get; set; }
    }
}
