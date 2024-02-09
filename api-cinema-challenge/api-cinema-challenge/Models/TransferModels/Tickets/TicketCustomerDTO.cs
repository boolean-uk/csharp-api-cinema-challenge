using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels.Seats;

namespace api_cinema_challenge.Models.TransferModels.Tickets
{
    public class TicketCustomerDTO(int NumSeats, Customer Customer, ICollection<Seat> seats)
    {
        public string CustomerName { get; set; } = Customer.CustomerName;

        public int NumSeats { get; set; } = NumSeats;

        public ICollection<SeatDTO> Seats { get; set; } = seats.Select(s => new SeatDTO(s.RowNumber, s.SeatNumber)).ToList();

    }
}
