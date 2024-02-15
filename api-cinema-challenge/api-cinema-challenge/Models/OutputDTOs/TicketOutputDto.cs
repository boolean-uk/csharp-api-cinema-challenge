using api_cinema_challenge.Models.Base;

namespace api_cinema_challenge.Models.OutputDTOs
{
    public class TicketOutputDto
    {
        public static object Create(Ticket ticket)
        {
            var customer = ticket.Customer;
            var screening = ticket.Screening;
            var movie = screening.Movie;

            var movieDto = new
            {
                movie.Id,
                movie.Title,
                movie.Description,
                movie.Rating,
                movie.RuntimeMins,
                movie.CreatedAt,
                movie.UpdatedAt,
            };

            var screeningDto = new
            {
                screening.Id,
                screening.StartsAt,
                screening.Capacity,
                screening.CreatedAt,
                screening.UpdatedAt,
                screening.ScreenNumber,
                movieDto
            };

            var customerDto = new
            {
                customer.Id,
                customer.Name,
                customer.Email,
                customer.Phone,
                customer.CreatedAt,
                customer.UpdatedAt,
            };

            var ticketDto = new
            {
                customerDto,
                screeningDto,
                ticket.NumSeats,
                ticket.CreatedAt,
                ticket.UpdatedAt
            };

            return ticketDto;
        }
    }
}
