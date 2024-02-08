using api_cinema_challenge.Models.CustomerModels;

namespace api_cinema_challenge.Services
{
    public static class CustomerDtoManager
    {
        public static Customer Convert(InputCustomer inputCustomer)
        {
            return new Customer
            {
                Name = inputCustomer.Name,
                Phone = inputCustomer.Phone,
                Email = inputCustomer.Email
            };
        }
    }
}
