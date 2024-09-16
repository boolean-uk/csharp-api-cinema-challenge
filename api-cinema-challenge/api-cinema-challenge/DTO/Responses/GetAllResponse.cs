namespace api_cinema_challenge.DTO.Responses
{
    public class GetAllResponse<T> where T : class
    {
        public List<T> ResponseData { get; set; } = new List<T>();
    }
}
