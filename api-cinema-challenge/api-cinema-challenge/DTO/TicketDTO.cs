using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.DTO
{
    public class TicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public TicketDTO(Ticket model)
        {
            Id = model.Id;
            NumSeats = model.NumSeats;
            CreatedAt = model.CreatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
            UpdatedAt = model.UpdatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}
