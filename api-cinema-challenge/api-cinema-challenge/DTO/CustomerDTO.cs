using api_cinema_challenge.Models;
using System.Security.Cryptography.X509Certificates;

namespace api_cinema_challenge
{
    public class CustomerDTO
    {
        public CustomerDTO(Customer customer) {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt;
            UpdatedAt = customer.UpdatedAt;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }



}
