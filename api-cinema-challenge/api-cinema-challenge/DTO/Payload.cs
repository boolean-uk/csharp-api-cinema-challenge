namespace api_cinema_challenge.DTO
{
    public class Payload
    {
        public record CreateCustomerPayload(string name, string email, string phone);
        public record UpdateCustomerPayload(string name, string email, string phone);
        public record CreateMoviePayload(string title, string rating, string description, int runtime);
        public record UpdateMoviePayload(string title, string rating, string description, int runtime);
        public record CreateScreeningPayload(int screennumber, int capacity, DateTime startsAt);
    }
}
