using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
        public TicketDTO(Ticket ticket)
        {
            Id = ticket.Id;
            SeatNumber = ticket.SeatNumber;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
        }
    }
    public class TicketResponseDTO{
        public string status { get;}
        public TicketDTO data { get; set; }
    
        public TicketResponseDTO(string status, Ticket data){
            this.status = status;
            this.data = new TicketDTO(data);
        }
    }

    public class TicketListResponseDTO{
        public string status { get;}
        public List<TicketDTO> data { get; set; }
    
        public TicketListResponseDTO(string status, IEnumerable<Ticket> data){
            this.status = status;
            this.data = new List<TicketDTO>();
            foreach (var ticket in data){
                this.data.Add(new TicketDTO(ticket));
            }
        }
    }
}