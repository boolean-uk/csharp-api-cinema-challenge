using api_cinema_challenge.Models;

namespace api_cinema_challenge.DOTs.MovieDTOs
{
    public class CustomerNoTicket
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public CustomerNoTicket(Customer customer)
        {
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;

        }
    }
}
