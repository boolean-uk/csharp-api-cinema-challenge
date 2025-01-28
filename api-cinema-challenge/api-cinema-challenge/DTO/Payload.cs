namespace api_cinema_challenge.DTO
{
    public class Payload<T>
    {
        public string status { get; set; }
        public List<T> data { get; set; } = new List<T>();
    }
   
}
