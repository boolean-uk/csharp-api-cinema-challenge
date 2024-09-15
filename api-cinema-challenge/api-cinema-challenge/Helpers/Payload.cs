namespace api_cinema_challenge.Helpers
{
    public class Payload<T>
    {
        public string Status { get; set; } = "Failure";
        public T load { get; set; } 
    }
    public class CollectionResponse<T>
    {
        public List<T> Load { get; set; } = new List<T>();
    }
}
