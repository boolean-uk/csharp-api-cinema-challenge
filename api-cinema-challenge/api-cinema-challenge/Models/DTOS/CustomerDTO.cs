using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class CustomerDTO
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string CreatedAt { get; init; }

        public string UpdatedAt { get; set; }

        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            string datePattern = "yyyy-MM-ddTHH:mm:ss";
            CreatedAt = customer.CreatedAt.ToString(datePattern);
            UpdatedAt = customer.UpdatedAt.ToString(datePattern);
        }
    }
}
