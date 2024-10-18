namespace api_cinema_challenge.DTOs
{
    public class GetCustomerDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }   
    }
}
