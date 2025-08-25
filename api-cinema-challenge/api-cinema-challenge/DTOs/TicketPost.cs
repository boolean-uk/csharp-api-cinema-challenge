using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOs
{
    public class TicketPost
    {
        public int NumSeats { get; set; }
        public int ScreeningId { get; set; }
        public int CustomerId { get; set; }
    }
}
