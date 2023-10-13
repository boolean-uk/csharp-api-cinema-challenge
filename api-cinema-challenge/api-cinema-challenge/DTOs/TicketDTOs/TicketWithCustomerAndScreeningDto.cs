using api_cinema_challenge.DTOs.CustomerDTOs;
using api_cinema_challenge.DTOs.ScreeningDTOs;

namespace api_cinema_challenge.DTOs.TicketDTOs
{
    public class TicketWithCustomerAndScreeningDto : TicketDataDto
    {
        public CustomerDataDto Customer { get; set; }
        public ScreeningDataDto Screening { get; set; }
    }
}
