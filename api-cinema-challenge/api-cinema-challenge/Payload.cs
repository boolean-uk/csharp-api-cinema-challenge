using System;

namespace api_cinema_challenge;

public class Payload<T> 
{
    public string Status {get;set;} = "Success";
    public T Data {get;set;}
    

}
