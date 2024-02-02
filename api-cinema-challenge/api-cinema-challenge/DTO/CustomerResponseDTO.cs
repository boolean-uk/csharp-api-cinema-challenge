using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challange.Models
{
    public class CustomerResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public CustomerResponseDTO(Customer Customer)
        {
            Id = Customer.Id;
            Name = Customer.Name;
            Email = Customer.Email;
            Phone = Customer.Phone;
            CreatedAt = Customer.CreatedAt;
            UpdatedAt = Customer.UpdatedAt;
        }

        public static List<CustomerResponseDTO> FromRepository(IEnumerable<Customer> Customers)
        {
            var results = new List<CustomerResponseDTO>();
            foreach (var Customer in Customers)
            {
                results.Add(new CustomerResponseDTO(Customer));
            }
            return results;
        }

        public static CustomerResponseDTO FromRepository(Customer Customer)
        {
            return new CustomerResponseDTO(Customer);
        }
    }
}