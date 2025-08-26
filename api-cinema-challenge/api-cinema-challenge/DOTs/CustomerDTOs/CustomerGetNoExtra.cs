using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.CustomerDTOs
{
    public class CustomerGetNoExtra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CustomerGetNoExtra(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
        }
    }
}
