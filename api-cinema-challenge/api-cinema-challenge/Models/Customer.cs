using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        List<Ticket> Tickets { get; set; } = new();

        public Customer() { }
        public Customer(PostCustomer customer)
        {
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }

    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CustomerDto(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt;
            UpdatedAt = customer.UpdatedAt;
        }
    }

    public class PostCustomer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
