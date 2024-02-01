using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<TicketCustomerDTO> Tickets { get; set; } = new List<TicketCustomerDTO>();

        public CustomerDTO(Customer customer) {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt;
            UpdatedAt = customer.UpdatedAt;
            Tickets = TicketCustomerDTO.FromRepository(customer.Tickets);
        }

        public static ICollection<CustomerDTO> FromRepository(IEnumerable<Customer> customers) {
            List<CustomerDTO> result = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                result.Add(new CustomerDTO(customer));
            }
            return result;
        }
    }
}