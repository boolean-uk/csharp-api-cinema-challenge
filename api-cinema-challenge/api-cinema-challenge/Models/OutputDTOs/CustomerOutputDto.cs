using api_cinema_challenge.Models.Base;

namespace api_cinema_challenge.Models.OutputDTOs
{
    public class CustomerOutputDto
    {
        public static object Create(Customer customer)
        {

            var customerDto = new
            {
                customer.Id,
                customer.Name,
                customer.Email,
                customer.Phone,
                customer.CreatedAt,
                customer.UpdatedAt,
            };

            return customerDto;
        }
    }
}
