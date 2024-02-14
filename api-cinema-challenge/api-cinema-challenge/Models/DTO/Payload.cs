namespace api_cinema_challenge.Models.DTO
{
    public class Payload<T>(T data) where T : class
    {
        public string Status { get; set; } = "success";
        public T Data { get; set; } = data;
    }
}
