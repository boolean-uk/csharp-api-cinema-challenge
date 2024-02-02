using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    
    public class CustomerDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public CustomerDTO(Customer customer) 
        {
            id = customer.id;
            name = customer.name;
            email = customer.email;
            phone = customer.phone;
            createdAt = customer.createdAt;
            updatedAt = customer.updatedAt;

           
        }
    }
}
