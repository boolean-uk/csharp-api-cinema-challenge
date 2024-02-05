namespace api_cinema_challenge.Models.DTOs
{
    public class CustomerListDTO
    {
        public string Status { get; set; }
        public ICollection<Customer> Data { get; set; } = new List<Customer>();
    }
}
