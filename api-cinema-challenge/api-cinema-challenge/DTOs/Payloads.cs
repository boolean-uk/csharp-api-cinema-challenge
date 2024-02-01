using System.Net.Mail;

namespace api_cinema_challenge.DTOs
{
    public class Payloads
    {
        public record CreateCustomerPayload(string Name, string Email, string Phone);
        public record UpdateCustomerPayload(string Name, string Email, string Phone);
        public record CreateMoviePayload( string Title, string Rating, string Description, int RuntimeMins);
        public record UpdateMoviePayload( string Title, string Rating, string Description, int RuntimeMins);
        public record CreateScreeningPayload(int ScreenNumber, int Capacity, DateTime StartsAt);
    }
}
