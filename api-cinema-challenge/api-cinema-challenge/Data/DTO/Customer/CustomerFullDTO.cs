using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {
    public class CustomerFullDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<TicketCustomerDTO> Tickets { get; set; } = [];

        public CustomerFullDTO(Customer customer) {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            Tickets = TicketCustomerDTO.FromRepository(customer.Tickets);
        }

        public static ICollection<CustomerFullDTO> FromRepository(IEnumerable<Customer> customers) {
            List<CustomerFullDTO> result = new List<CustomerFullDTO>();
            foreach (var customer in customers)
            {
                result.Add(new CustomerFullDTO(customer));
            }
            return result;
        }
    }
}