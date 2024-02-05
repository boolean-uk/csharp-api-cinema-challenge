namespace api_cinema_challenge.Models.DTOs
{
    public class ScreeningForBookingDTO
    {
        public int? Id { get; set; }

    }

    public class BookingDTO
    {
        public int Id { get; set; }
        public string? TitleOfMovie { get; set; }
        public string? ScreenName { get; set; }

        public int? NumberOfTickets { get; set; }



        public DateTime? StartTime { get; set; }
        public ScreeningForBookingDTO? Screening { get; set; }
        public List<TicketForBookingDTO> Tickets { get; set; } = new List<TicketForBookingDTO>();


        public static BookingDTO FromBooking(Booking Booking)
        {
            if (!Booking.tickets.Any()) {
                return new BookingDTO()
                {
                    Id = Booking.Id,
                };
            }


            return new BookingDTO
            {
                Id = Booking.Id,
                TitleOfMovie = Booking.tickets.First().screening.Movie.Title,
                ScreenName = Booking.tickets.First().seat.Screen.name,
                NumberOfTickets = Booking.tickets.Count(),
                StartTime = Booking.tickets.First().screening.StartsAt,
                Screening = new ScreeningForBookingDTO() { Id =  Booking.tickets.FirstOrDefault().screening.Id },
                Tickets = TicketForBookingDTO.FromTicketList(Booking.tickets)


            };
        }

        public static List<BookingDTO> FromListOfBookings(List<Booking> Bookings)
        {
            return Bookings.Select(FromBooking).ToList();
        }
    }


    public class TicketForBookingDTO
    {

        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public int rowNumber { get; set; }

        public TicketForBookingDTO(Ticket ticket)
        {
            Id = ticket.Id;
            SeatNumber = ticket.seat.seatNumber;
            rowNumber = ticket.seat.rowNumber;
        }

        public static List<TicketForBookingDTO> FromTicketList(List<Ticket> tickets)
        {
            List<TicketForBookingDTO> ticketForBookingDTOs = new List<TicketForBookingDTO>();
            foreach (var t in tickets)
            {
                ticketForBookingDTOs.Add(new TicketForBookingDTO(t));
            }
            return ticketForBookingDTOs;

        }
    }
}
