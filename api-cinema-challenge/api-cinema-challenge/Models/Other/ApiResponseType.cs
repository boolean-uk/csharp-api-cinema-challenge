namespace api_cinema_challenge.Models.Other
{
    public class ApiResponseType<T>
    {
        public ApiResponseCodes Status { get; set; } = ApiResponseCodes.Success;
        public T Data { get; set; }
    }
}
