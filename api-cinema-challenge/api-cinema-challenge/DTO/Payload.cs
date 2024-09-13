namespace api_cinema_challenge.DTO
{
    public class Payload<DTO> where DTO : class
    {
        public string Status { get; set; }
        public DTO Data { get; set; }
    }
}
