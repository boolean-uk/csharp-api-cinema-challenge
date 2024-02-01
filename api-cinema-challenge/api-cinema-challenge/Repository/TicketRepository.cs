using api_cinema_challenge.Data;
using api_cinema_challenge.Model;
using api_cinema_challenge.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository {

    public class TicketRepository : ITicketRepository
    {
        private CinemaContext _db;

        public TicketRepository(CinemaContext db) {
            _db = db;
        }
        public async Task<Ticket?> CreateTicket(int customerId, int screeningId, IEnumerable<string> seats)
        {
            if (screeningId == 0)
                return null;

            var screening = await _db.Screenings
                .Include(screening => screening.Seats)
                .ThenInclude(seat => seat.Ticket)
                .Include(screening => screening.Movie)
                .Where(screening => screening.Id == screeningId)
                .FirstOrDefaultAsync();

            if (screening == null)
            {
                return null;
            }

            var requestedSeats = seats.Select(seat => new { SeatRow = seat.Substring(0, 1), SeatNumber = int.Parse(seat.Substring(1)) });
            var availableSeats = screening.Seats.Where(s => s.Ticket == null);

            var matchingAvailableSeats = availableSeats.Where(s => requestedSeats.Contains(new { SeatRow = s.SeatRow, SeatNumber = s.SeatNumber }));

            if (matchingAvailableSeats.Count() != seats.Count())
            {
                throw new InvalidOperationException("Requested seats are not available.");
            }

            var ticket = new Ticket
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
            };

            _db.Tickets.Add(ticket);

            foreach (var requestedSeat in requestedSeats)
            {
                var seat = availableSeats.First(s => s.SeatRow == requestedSeat.SeatRow && s.SeatNumber == requestedSeat.SeatNumber);
                seat.TicketId = ticket.Id;
            }

            await _db.SaveChangesAsync();

            return ticket;
        }
        public Task DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicket(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetTicketsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetTicketsByScreeningId(int screeningId)
        {
            throw new NotImplementedException();
        }
    }
}