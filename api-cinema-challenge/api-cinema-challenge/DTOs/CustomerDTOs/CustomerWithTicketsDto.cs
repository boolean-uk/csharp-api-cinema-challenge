using api_cinema_challenge.DTOs.TicketDTOs;

namespace api_cinema_challenge.DTOs.CustomerDTOs
{
    public class CustomerWithTicketsDto : CustomerDataDto
    {
        public List<TicketDataDto> Tickets { get; set; }
        // Inherits from CustomerDataDto to dont have the reference issues.
    }
}
