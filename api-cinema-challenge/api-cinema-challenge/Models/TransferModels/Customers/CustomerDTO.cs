using api_cinema_challenge.Models.PureModels;

namespace api_cinema_challenge.Models.TransferModels.Customers
{
    public class CustomerDTO(Customer customer)
    {
        public int Id { get; set; } = customer.CustomerId;

        public string Name { get; set; } = customer.CustomerName;

        public string Email { get; set; } = customer.Email;

        public string Phone { get; set; } = customer.PhoneNumber;

        public string createdAt { get; set; } = customer.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");

        public string updatedAt { get; set; } = customer.UpdatedAt.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
    }
}
