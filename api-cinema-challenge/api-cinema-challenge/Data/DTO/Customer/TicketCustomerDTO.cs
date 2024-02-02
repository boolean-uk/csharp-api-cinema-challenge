using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {
    public class TicketCustomerDTO
    {
        public int Id { get; set; }
        public int ScreeningId {get; set;}
        //public ICollection<SeatDTO> Seats {get; set;}
        
        public TicketCustomerDTO(Ticket ticket) {
            Id = ticket.Id;
            //Seats = SeatDTO.FromRepository(ticket.Seats);
            ScreeningId = ticket.ScreeningId;
        }

        public static ICollection<TicketCustomerDTO> FromRepository(IEnumerable<Ticket> tickets) {
            List<TicketCustomerDTO> result = new List<TicketCustomerDTO>();
            foreach (var ticket in tickets)
            {
                result.Add(new TicketCustomerDTO(ticket));
            }
            return result;
        }
    }
}