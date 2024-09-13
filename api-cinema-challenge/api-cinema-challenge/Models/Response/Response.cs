namespace api_cinema_challenge.Models.Response
{
    public class Response
    {
        public string Status { get; set; }
        public Object Data { get; set; }

        public Response(string status, Object data)
        {
            Status = status;
            Data = data;
        }
    }
}