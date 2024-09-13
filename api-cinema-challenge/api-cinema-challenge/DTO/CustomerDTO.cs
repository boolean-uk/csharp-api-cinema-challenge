using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public CustomerDTO(Customer model)
        {
            Id = model.Id;
            Name = model.Name;
            Email = model.Email;
            Phone = model.Phone;
            CreatedAt = model.CreatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
            UpdatedAt = model.UpdatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}
