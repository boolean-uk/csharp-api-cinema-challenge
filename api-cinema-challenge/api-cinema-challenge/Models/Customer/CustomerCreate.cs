using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Customer
{
    [NotMapped]
    public class CustomerCreate
    {
        public string status { get; set; } = "success";
        public Customer data { get; set; }
    }
}
