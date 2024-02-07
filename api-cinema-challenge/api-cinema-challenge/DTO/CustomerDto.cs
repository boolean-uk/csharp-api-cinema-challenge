using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime CreatedAt {get ; set;} 
        public DateTime UpdateddAt { get; set; } 

        public CustomerDto(Customer customer) 
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt;
            UpdateddAt = customer.UpdatedAt;

                
        }
    }
}
