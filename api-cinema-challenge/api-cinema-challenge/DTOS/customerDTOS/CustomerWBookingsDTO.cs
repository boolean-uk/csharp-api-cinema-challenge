using api_cinema_challenge.Models.DTOS;

namespace api_cinema_challenge.Models
{
    public class CustomerWBookingsDTO
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string CreatedAt { get; init; }

        public string UpdatedAt { get; set; }
        public ICollection<BasicBookingsCustomerDTO> Bookings { get; set; } = new List<BasicBookingsCustomerDTO>();

        public CustomerWBookingsDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            string datePattern = "yyyy-MM-ddTHH:mm:ss";
            CreatedAt = customer.CreatedAt.ToString(datePattern);
            UpdatedAt = customer.UpdatedAt.ToString(datePattern);
            foreach (var booking in customer.Bookings)
            {
                Bookings.Add(new BasicBookingsCustomerDTO(booking));
            }
        }
    }
}
