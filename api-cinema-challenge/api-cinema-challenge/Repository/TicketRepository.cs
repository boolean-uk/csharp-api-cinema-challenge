using api_cinema_challenge.Data;
using api_cinema_challenge.Data.Payload;
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
        public async Task<Ticket?> CreateTicket(int customerId, int screeningId, List<CreateSeatPayload> seats)
        {
            if (screeningId == 0)
                return null;

            var screening = await _db.Screenings
                .Include(s => s.Seats)
                .Include(s => s.Movie)
                .Where(s => s.Id == screeningId)
                .FirstOrDefaultAsync();

            if (screening == null)
            {
                return null;
            }

            var requestedSeats = seats.Select(seat => new { SeatRow = seat.SeatRow, SeatNumber = seat.SeatNumber });
            var availableSeats = screening.Seats.Where(s => s.TicketId == null);

            var matchingAvailableSeats = availableSeats
                .Where(s => requestedSeats.Any(reqSeat => reqSeat.SeatRow == s.SeatRow && reqSeat.SeatNumber == s.SeatNumber))
                .ToList();

            if (matchingAvailableSeats.Count != seats.Count)
            {
                throw new InvalidOperationException("Requested seats are not available.");
            }

            var ticket = new Ticket
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Seats = new List<Seat>()
            };

            _db.Tickets.Add(ticket);

            foreach (var requestedSeat in requestedSeats)
            {
                var seat = matchingAvailableSeats
                    .FirstOrDefault(s => s.SeatRow == requestedSeat.SeatRow && s.SeatNumber == requestedSeat.SeatNumber);

                if (seat == null)
                {
                    throw new InvalidOperationException($"Seat {requestedSeat.SeatRow}{requestedSeat.SeatNumber} is not available.");
                }

                seat.TicketId = ticket.Id;
                ticket.Seats.Add(seat);
            }

            await _db.SaveChangesAsync();

            return ticket;
        }
        public Task DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Ticket?> GetTicket(int id)
        {
            if(id <= 0)
                return null;
            var ticket = await _db.Tickets
                    .Include(ticket => ticket.Seats)
                    .Where(ticket => ticket.Id == id)
                    .FirstOrDefaultAsync();
            if(ticket == null)
                return null;
            return ticket;
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