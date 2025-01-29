namespace api_cinema_challenge.Response
{
    public class Error
    {
        public string message { get; set; }
        public Error(string message)
        {
            this.message = message;
        }
    }
}
