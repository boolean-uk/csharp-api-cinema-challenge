using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class CustomerResponseDTO
    {
        public string Status { get; set; }

        public CustomerDataDTO Datas { get; set; }

        public CustomerResponseDTO(Customer customer)
        {
            Status = "Success";
            Datas = new CustomerDataDTO(customer);
        }

        public static List<CustomerResponseDTO> FromRepository(IEnumerable<Customer> customers)
        {
            var results = new List<CustomerResponseDTO>();
            foreach (var customer in customers)
                results.Add(new CustomerResponseDTO(customer));
            return results;
        }

        public static CustomerResponseDTO FromARepository(Customer customer)
        {
            CustomerResponseDTO result = new CustomerResponseDTO(customer);
            return result;
        }
    }
}
