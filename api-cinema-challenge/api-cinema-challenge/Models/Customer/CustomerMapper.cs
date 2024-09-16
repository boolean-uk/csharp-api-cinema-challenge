
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Models.Customer
{
    public static class CustomerMapper
    {
        public static CustomerDTO MapToDTO(this Customer customer)
        {
            return new CustomerDTO
            {
                id = customer.id,
                name = customer.name,
                email = customer.email,
                phone = customer.phone,
                createdAt = customer.createdAt,
                updatedAt = customer.updatedAt
            };
        }

        public static List<CustomerDTO> MapListToDTO(this List<Customer> customers)
        {
            return customers.Select(customer => new CustomerDTO
            {
                id = customer.id,
                name = customer.name,
                email = customer.email,
                phone = customer.phone,
                createdAt = customer.createdAt,
                updatedAt = customer.updatedAt
            }).ToList();
        }
    }
}
