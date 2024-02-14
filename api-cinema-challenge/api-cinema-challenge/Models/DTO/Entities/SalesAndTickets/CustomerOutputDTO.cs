using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;

namespace api_cinema_challenge.Models.DTO.Entities.SalesAndTickets
{
    public class CustomerOutputDTO
    {
        public CustomerOutputDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
            UpdatedAt = customer.UpdatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
