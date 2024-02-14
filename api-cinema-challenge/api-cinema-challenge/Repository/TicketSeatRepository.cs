using api_cinema_challenge.Data;
using api_cinema_challenge.Models.JunctionModel;
using api_cinema_challenge.Models.PureModels;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class TicketSeatRepository
    {
        DataContext _db;
        private DbSet<TicketSeat> _table_TS = null;
        private DbSet<Seat> _table_Seat = null;

        public TicketSeatRepository(DataContext db)
        {
            _db = db;
            _table_TS = _db.TicketSeats;
            _table_Seat = _db.Seats;
        }

        /// <summary>
        /// Retrieve a specific TicketSeat object
        /// </summary>
        /// <param name="seatId">SeatID int</param>
        /// <param name="displayId">DisplayId int</param>
        /// <param name="screeningId">ScreeningID int</param>
        /// <returns>the found ticketSeat object</returns>
        public async Task<TicketSeat?> Get(int seatId, int displayId, int screeningId) 
        {
            return await _db.TicketSeats.FindAsync(screeningId, displayId, seatId);
        }

        public async Task<TicketSeat> Insert(TicketSeat ts) 
        {
            var addedEntity = _table_TS.Add(ts);
            await _db.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<TicketSeat> Update(TicketSeat ts)
        {
            var entry = _table_TS.Entry(ts);
            entry.State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return ts;
        }

        public async Task<List<Seat>> GetAvailableSeats(int DisplayId, int ScreeningId) 
        {
            List<int> seatIds = await _table_TS
                .Where(e => e.DisplayId == DisplayId && e.ScreeningId == ScreeningId)
                .Where(e => e.TicketId == null)
                .Select(e => e.SeatId)
                .ToListAsync();
            return await _table_Seat.Where(s => seatIds.Contains(s.SeatId)).ToListAsync();
        }

        public async Task<List<Seat>> GetUnavailableSeats(int DisplayId, int ScreeningId)
        {
            List<int> seatIds = await _table_TS
                .Where(e => e.DisplayId == DisplayId && e.ScreeningId == ScreeningId)
                .Where(e => e.TicketId != null)
                .Select(e => e.SeatId)
                .ToListAsync();
            return await _table_Seat.Where(s => seatIds.Contains(s.SeatId)).ToListAsync();
        }
    }
}
