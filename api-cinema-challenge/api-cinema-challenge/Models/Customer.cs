using api_cinema_challenge.DOTs.CustomerDTOs;
using api_cinema_challenge.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("customer_tickets")]
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Customer(CustomerPost newCustomer)
        {
            Name = newCustomer.Name;
            Email = newCustomer.Email;
            Phone = newCustomer.Phone;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
        public Customer() 
        { 
            CreatedAt= DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
