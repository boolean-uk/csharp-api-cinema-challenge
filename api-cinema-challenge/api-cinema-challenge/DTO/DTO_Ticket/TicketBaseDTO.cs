namespace api_cinema_challenge.DTO.DTO_Ticket
{
    public class TicketBaseDTO
    {
        public string status { get; set; }

        public TicketDTO data { get; set; }

        public TicketBaseDTO(TicketDTO ticket)
        {
            status = "success";
            data = ticket;
        }
    }
}
