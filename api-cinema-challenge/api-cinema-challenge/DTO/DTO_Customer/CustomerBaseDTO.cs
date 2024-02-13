using System.Net.NetworkInformation;

namespace api_cinema_challenge.DTO.DTO_Customer
{
    public class CustomerBaseDTO
    {

        public string status { get; set; }

        public CustomerDTO data { get; set; }

        public CustomerBaseDTO(CustomerDTO customer)
        {
            status = "success";
            data = customer;
        }


    }
}
