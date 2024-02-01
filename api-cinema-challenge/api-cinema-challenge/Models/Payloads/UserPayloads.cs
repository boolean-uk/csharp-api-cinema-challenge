namespace api_cinema_challenge.Models.Payloads
{
    public class UserPayloads
    {

        public record UserPostPayload(string name, string email, string phonenumber);
        public record UserPutPayload(string? name, string? email, string? phonenumber);
    }
}
