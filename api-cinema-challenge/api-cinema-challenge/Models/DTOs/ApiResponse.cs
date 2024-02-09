namespace api_cinema_challenge.Models.DTOs
{
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public string Status { get; set; }
    }
}
