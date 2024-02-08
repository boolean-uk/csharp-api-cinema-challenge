using api_cinema_challenge.Models.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("phone_number")]
        public string? PhoneNumber { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

        public static PayLoad<CustomerDTO> ToDTO(Customer customer)
        {
            CustomerDTO responseDTO = new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt
            };

            return new PayLoad<CustomerDTO> { Data = responseDTO };
        }

        public static PayLoad<List<CustomerDTO>> ToDTO(ICollection<Customer> customers)
        {
            List<CustomerDTO> customerResponses = new List<CustomerDTO>();
            foreach (Customer customer in customers)
            {
                customerResponses.Add(new CustomerDTO
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    CreatedAt = customer.CreatedAt
                });
            }

            return new PayLoad<List<CustomerDTO>> { Data = customerResponses.OrderBy(x => x.Id).ToList() };
        }
    }
}
