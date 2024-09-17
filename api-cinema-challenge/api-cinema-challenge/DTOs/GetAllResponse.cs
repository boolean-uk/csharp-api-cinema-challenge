namespace api_cinema_challenge.DTOs
{
    public class GetAllResponse<T>
    {
        public List<T> Response { get; set; } = new List<T>();
    }
}
