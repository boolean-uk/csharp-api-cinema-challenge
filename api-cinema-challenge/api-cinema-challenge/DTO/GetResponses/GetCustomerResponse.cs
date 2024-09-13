namespace api_cinema_challenge.DTO.GetResponses
{
    public class GetCustomerResponse
    {
        public ICollection<CustomerDTO> Customers { get; set; } = new List<CustomerDTO>();
    }
}
