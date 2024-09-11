using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;

namespace api_cinema_challenge.Extensions
{
    public static class CustomerExtensions
    {
        public static Customer ToCustomer(this CustomerPostModel customerPost) 
        {
            return new Customer()
            {
                Name = customerPost.Name,
                Email = customerPost.Email,
                Phone = customerPost.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }

        public static CustomerDTO ToCustomerDTO(this Customer customer) 
        {
            return new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                PhoneNr = customer.Phone,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt
            };
        }
    }
}
