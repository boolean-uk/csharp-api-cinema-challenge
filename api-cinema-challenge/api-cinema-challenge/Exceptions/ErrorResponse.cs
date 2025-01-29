namespace api_cinema_challenge.Exceptions
{
    internal class ErrorResponse
    {
        public string Header { get; set; } = "An unexpected error occurred while processing the request.";
        public string Message { get; set; }
    }
}
