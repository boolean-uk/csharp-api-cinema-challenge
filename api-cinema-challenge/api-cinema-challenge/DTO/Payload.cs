using System;

namespace api_cinema_challenge.DTO;

public class Payload<T>
{
    public string Message { get; set; }
    public T Data { get; set; }

    public Payload(T data)
    {
        Message = "success";
        Data = data;
    }
}
