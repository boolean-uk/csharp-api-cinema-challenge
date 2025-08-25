using api_cinema_challenge.DTOs.Customer;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Factories
{
    public static class CustomerFactory
    {
        public static CustomerDto DtoFromCustomer(Customer customer)
        {
            var dto = new CustomerDto();

            dto.Id = customer.Id;
            dto.Name = customer.Name;
            dto.Email = customer.Email;
            dto.Phone = customer.Phone;
            dto.CreatedAt = customer.CreatedAt;
            dto.UpdatedAt = customer.UpdatedAt;

            return dto;
        }

        public static Customer CustomerFromPostDto(CustomerPostDto dto) 
        { 
            var customer = new Customer();
            
            customer.Name = dto.Name;
            customer.Email = dto.Email;
            customer.Phone = dto.Phone;
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;

            return customer;
        }

        public static Customer CustomerFromPutDto(CustomerPutDto dto, Customer oldCustomer)
        {
            var updated = oldCustomer;

            if (dto.Name is not null) updated.Name = dto.Name;
            if (dto.Email is not null) updated.Email = dto.Email;
            if (dto.Phone is not null) updated.Phone = dto.Phone;

            return updated;
        }
    }
}
