using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Service
{
    public static class CustomerService
    {
        public static Customer toCustomer(CustomerDto customerDto)
        {
            return new Customer()
            {
                Name = customerDto.Name,
                Email = customerDto.Email,
                Phone = customerDto.Phone,
                CreatedAt = DateTime.UtcNow, 
                UpdatedAt = DateTime.UtcNow
            };
        }

        public static Customer updateCustomer(Customer customer, CustomerDto customerDto)
        {
            customer.Name = customerDto.Name.Trim().Count() == 0 ? customer.Name : customerDto.Name;
            customer.Email = customerDto.Email.Trim().Count() == 0 ? customer.Email : customerDto.Email;
            customer.Phone = customerDto.Phone.Trim().Count() == 0 ? customer.Phone : customerDto.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            return customer;
        }
    }
}
