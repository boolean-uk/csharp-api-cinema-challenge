using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels.Customers;
using api_cinema_challenge.Models.TransferModels.Movies;
using api_cinema_challenge.Models.TransferModels.Screenings;
using Newtonsoft.Json;

namespace api_cinema_challenge.Models.TransferModels.Tickets
{
    public class TicketWithCustomerAndMovieDTO(int TicketId, int NumSeats, DateTime Created, DateTime Updated, Customer customer, Screening screening)
    {
        public int Id { get; set; } = TicketId;

        public int NumSeats { get; set; } = NumSeats;

        public string CreatedAt { get; set; } = Created.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string UpdatedAt { get; set; } = Updated.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public CustomerDTO Customer { get; set; } = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);

        public ScreeningDTO Screening { get; set; } = new ScreeningDTO(screening.ScreeningId, screening.ScreenNumber, screening.Capacity, screening.Starts, screening.CreatedAt, screening.UpdatedAt);

        public MovieDTO Movie { get; set; } = new MovieDTO(screening.Movie.MovieId, screening.Movie.Title, screening.Movie.Rating, screening.Movie.Description, screening.Movie.RuntimeMinutes, screening.Movie.CreatedAt, screening.Movie.UpdatedAt);
    }
}
