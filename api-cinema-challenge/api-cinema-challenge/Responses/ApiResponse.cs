using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using AutoMapper;

namespace api_cinema_challenge.Responses
{
    public class ApiResponse<T>
    {
        private string _status;
        private T _data;
        public ApiResponse(ApiStatus status, T data)
        {
            _status = status.ToString();
            _data = data;
        }

        public string Status { get => _status; set => _status = value; }
        public T Data { get => _data; set => _data = value; }
    }
}
