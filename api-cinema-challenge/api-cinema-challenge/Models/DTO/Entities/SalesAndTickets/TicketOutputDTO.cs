using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;

namespace api_cinema_challenge.Models.DTO.Entities.SalesAndTickets
{
    public class TicketOutputDTO
    {
        public TicketOutputDTO(Ticket ticket)
        {
            Id = ticket.Id;
            NumSeats = ticket.ScreeningSeats.Count;
            CreatedAt = ticket.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
            UpdatedAt = ticket.UpdatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
            Seats = new List<ScreeningSeatOutputDTO>();
            foreach (ScreeningSeat seat in ticket.ScreeningSeats)
            {
                Seats.Add(new ScreeningSeatOutputDTO(seat));
            }

        }
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public List<ScreeningSeatOutputDTO> Seats { get; set; }
    }
}
