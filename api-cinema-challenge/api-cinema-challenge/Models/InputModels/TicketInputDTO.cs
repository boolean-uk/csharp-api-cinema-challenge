using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models.InputModels
{
    public class TicketInputDTO(int numSeats)
    {
        public int numSeats { get; set; } = numSeats;

    }
}
