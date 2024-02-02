namespace api_cinema_challenge.DTO
{
    public  class RequestDTO
    {
        public string ResponseStatus { get; set; }
            public object? data { get; set; }
        public RequestDTO(string ResponseStatus, object data) { 
            this.ResponseStatus = ResponseStatus;
            this.data = data;
        }


        public static RequestDTO Success(object data)
        {
            return new RequestDTO("Success", data);

        }
        public static RequestDTO BadRequest(object? data =null)
        {
            return new RequestDTO("BadRequest", data);
        }

        public static RequestDTO NotFound(object? data = null)
        {
            return new RequestDTO("NotFound", data);
        }


    }

}
