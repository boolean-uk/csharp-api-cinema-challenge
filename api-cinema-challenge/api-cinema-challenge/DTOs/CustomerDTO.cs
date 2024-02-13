using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{

    public class CustomerDTO
    {
        public int id { get; }
        public string name { get; }
        public string email { get; }
        public string phone { get; }
        public CustomerDTO(Customer customer)
        {
            id = customer.Id;
            name = customer.Name;
            email = customer.Email;
            phone = customer.Phone;
        }
    }
}
