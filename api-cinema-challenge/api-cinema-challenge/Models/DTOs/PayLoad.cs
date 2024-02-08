using api_cinema_challenge.Models.DTOs;

namespace api_cinema_challenge.Models.DTOs
{
    public class PayLoad<T> where T : class
    {
        public string Status { get; set; } = "success";
        public required T Data { get; set; }
    }
}
