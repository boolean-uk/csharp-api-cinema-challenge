using api_cinema_challenge.Models.JunctionModel;
using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Utils
{
    public static class SeatGenerator
    {
        private static Random rng = new Random();
        public static List<Tuple<Seat, TicketSeat>> FillSeatAndTicketSeat(int RoomCapacity, int DisplayId, int ScreeningId) 
        {
            List<Tuple<Seat, TicketSeat>> GeneratedSeats = new List<Tuple<Seat, TicketSeat>>();
            int seats = RoomCapacity;
            int rows = rng.Next(3, Math.Max(6, seats / 6));
            int seatPerRow = seats / rows;

            for (int i = 1; i <= seats; i++)
            {
                int RowNumber = i - 1 / seatPerRow + 1;
                int seatNumber = (i - 1) % seatPerRow + 1;

                Seat seat = new Seat();
                seat.SeatId = i;
                seat.RowNumber = RowNumber;
                seat.SeatNumber = seatNumber;
                seat.DisplayId = DisplayId;

                TicketSeat ticketSeat = new TicketSeat() { SeatId = seat.SeatId, DisplayId = DisplayId, ScreeningId = ScreeningId };

                GeneratedSeats.Add(new Tuple<Seat, TicketSeat>(seat, ticketSeat));
            }

            return GeneratedSeats;
        }

        public static List<Seat> FillSeat(int RoomCapacity, int DisplayId) 
        {
            List<Seat> GeneratedSeats = new List<Seat>();

            int rows = rng.Next(3, Math.Max(6, RoomCapacity / 6));
            int seatPerRow = RoomCapacity / rows;


            for (int i = 1; i <= RoomCapacity; i++)
            {
                int RowNumber = i - 1 / seatPerRow + 1;
                int seatNumber = (i - 1) % seatPerRow + 1;

                Seat seat = new Seat();
                seat.SeatId = i;
                seat.RowNumber = RowNumber;
                seat.SeatNumber = seatNumber;
                seat.DisplayId = DisplayId;

                GeneratedSeats.Add(seat);
            }

            return GeneratedSeats;
        }

        public static List<TicketSeat> GetScreeningSeatConnection(int RoomCapacity, int DisplayId, int ScreeningId) 
        {
            List<TicketSeat> ticketSeats = new List<TicketSeat>();

            for (int i = 1; i < RoomCapacity; i++) 
            {
                TicketSeat ts = new TicketSeat() 
                {
                    SeatId = i,
                    DisplayId = DisplayId,
                    ScreeningId = ScreeningId
                };
                ticketSeats.Add(ts);
            }

            return ticketSeats;
        }
    }
}
