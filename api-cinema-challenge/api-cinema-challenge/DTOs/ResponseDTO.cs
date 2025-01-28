namespace api_cinema_challenge.DTOs
{
    public class ResponseDTO<T> where T : class
    {
        public string Status { get; set; } = "Success";

        public IEnumerable<T> Data { get; set; }
    }
}
