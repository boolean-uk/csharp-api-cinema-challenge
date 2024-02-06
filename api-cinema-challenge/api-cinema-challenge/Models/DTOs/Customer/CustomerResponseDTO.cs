namespace api_cinema_challenge.Models.DTOs.Customer
{
    public class CustomerResponseDTO
    {
        public string Status { get; set; } = "success";
        public CustomerDTO? Data { get; set; }
    }
}
