namespace api_cinema_challenge.DTO
{
    public class RequestDTO
    {
        public string ResponseStatus { get; set; }
            public object data { get; set; }
        public RequestDTO(string ResponseStatus, object data) { 
            this.ResponseStatus = ResponseStatus;
            this.data = data;
        }
    }
    public class RequestSuccessDTO : RequestDTO
    {

        public RequestSuccessDTO(object data) : base("Success", data) { }


    }
}
