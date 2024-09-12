using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.ViewModels
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
            this.id = customer.Id;
            this.name = customer.Name;
            this.email = customer.Email;
            this.phone = customer.Phone;
            this.createdAt = customer.CreatedAt;
            this.updatedAt = customer.UpdatedAt;
        }
    }
}
