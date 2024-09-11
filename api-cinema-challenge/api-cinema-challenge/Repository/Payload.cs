namespace api_cinema_challenge.Repository
{
    public class Payload<T> where T : class
    {
        public string status {  get; set; } 
        public T payload { get; set; }
    }
}
