namespace api_cinema_challenge.DTOs.CustomerDTOs
{
    public class AllCustomersDto
    {
        public string Status { get; set; }
        public List<CustomerWithTicketsDto> Data { get; set; }
    }
}
