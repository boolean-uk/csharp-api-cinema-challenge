namespace api_cinema_challenge.Models.DTOs.Customer
{
    public class CustomerResponseListDTO
    {
        public string Status { get; set; } = "success";
        public ICollection<CustomerDTO> Data { get; set; } = new List<CustomerDTO>();
    }
}
