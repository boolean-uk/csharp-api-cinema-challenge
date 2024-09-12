using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.VIewModelsCustomer
{
    public class CustomerDTO
    {
        public string status { get; set; }
        public CustomerData data { get; set; }

        public CustomerDTO(Customer customer)
        {
            status = "success";
            data = new CustomerData(customer);
        }
    }
}
