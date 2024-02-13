using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketDto
    {
        public ScreeningDto Screening { get; set; }
        public SeatDto Seat { get; set; }

        public TicketDto(Ticket ticket)
        {
            //Async issue; Nigel please fix if you have time :)
            if(ticket == null)
            {
                Screening = null;
                Seat = null;
            } else
            {
                Screening = new ScreeningDto(ticket.Screening);
                Seat = new SeatDto(ticket.Seat);
            }
        }

        public TicketDto()
        {
            
        }
    }
}
