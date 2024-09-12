using api_cinema_challenge.Models;

namespace api_cinema_challenge.VIewModelsCustomer
{
    public class CustomerGetDTO
    {
        public string status { get; set; }
        public List<CustomerData> data { get; set; } = new List<CustomerData>();

        public CustomerGetDTO(List<Customer> customers)
        {
            status = "success";
            foreach (var customer in customers)
            {
                data.Add(new CustomerData(customer));
            }
        }
    }
}
