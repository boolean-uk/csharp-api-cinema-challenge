using System.Net.NetworkInformation;

namespace api_cinema_challenge.DTO
{
    public class CustomerBaseDTO
    {

        public string status {  get; set; }

        public CustomerDTO data { get; set; }

        public CustomerBaseDTO(CustomerDTO customer)
        {
            status = "success";
            data = customer;
        }
        
        
    }
}
