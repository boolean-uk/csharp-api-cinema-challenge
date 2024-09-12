using api_cinema_challenge.Models;

namespace api_cinema_challenge.VIewModelsCustomer
{
    public class CustomerData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public CustomerData(Customer customer)
        {
            id = customer.Id;
            name = customer.Name;
            email = customer.Email;
            phone = customer.Phone;
            createdAt = customer.CreatedAt;
            updatedAt = customer.UpdatedAt;
        }
    }
}
