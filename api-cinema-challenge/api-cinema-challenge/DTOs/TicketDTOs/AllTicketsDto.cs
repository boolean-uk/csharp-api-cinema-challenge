namespace api_cinema_challenge.DTOs.TicketDTOs
{
    public class AllTicketsDto
    {
        public string Status { get; set; }
        public List<TicketDataDto> Data { get; set; }
    }
}
