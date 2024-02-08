namespace workshop.wwwapi.Models
{
    public static class ApiStatus
    {
        public const string Success = "success";
        public const string NotFound = "not found";
    }

    public class Payload<T> where T : class
    {
        public Payload(T data)
        {
            Data = data;
            Status = data == null ? ApiStatus.NotFound : ApiStatus.Success;
        }

        public string Status { get; set; }
        public T Data { get; set; }
    }
}
