using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class CustomerResponseDTO{
        public string status { get;}
        public IEnumerable<Customer> data { get; set; }

        public CustomerResponseDTO(string status, IEnumerable<Customer> data){
            this.status = status;
            this.data = data;
        }
    }
}