using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.DTO.Entities.SalesAndTickets;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("customers");
            group.MapGet("/", GetAll);
            group.MapPost("/", Create);
            group.MapPut("/{id}", Update);
            group.MapDelete("/{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAll(IRepository<Customer> customerRepository)
        {
            IEnumerable<Customer> results = await customerRepository.GetAll();
            List<CustomerOutputDTO> resultDTOs = new List<CustomerOutputDTO>();
            foreach (var customer in results)
            {
                resultDTOs.Add(new CustomerOutputDTO(customer));
            }
            return TypedResults.Ok(new Payload<IEnumerable<CustomerOutputDTO>>(resultDTOs));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> Update(IRepository<Customer> customerRepository, int id, CustomerInputDTO input)
        {
            Customer? customer = await customerRepository.GetById(id);
            if (customer == null) return TypedResults.NotFound($"Could not find any customer with id={id}.");
            customer.Name = input.Name;
            customer.Email = input.Email;
            customer.Phone = input.Phone;
            customer.UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Customer result = await customerRepository.Update(customer);
            CustomerOutputDTO resultDTO= new CustomerOutputDTO(result);
            return TypedResults.Created($"/{result.Id}", new Payload<CustomerOutputDTO>(resultDTO));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> Delete(IRepository<Customer> customerRepository, int id)
        {
            Customer? result = await customerRepository.DeleteById(id);
            if (result == null) return TypedResults.NotFound($"Could not find any customer with id={id}.");
            CustomerOutputDTO resultDTO = new CustomerOutputDTO(result);
            return TypedResults.Ok(new Payload<CustomerOutputDTO>(resultDTO));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Customer> customerRepository, CustomerInputDTO input)
        {
            Customer newCustomer = new Customer()
            {
                Name = input.Name,
                Email = input.Email,
                Phone = input.Phone,
                Age = input.Age,
                Weight = input.WeightInKilograms
            };
            Customer result = await customerRepository.Insert(newCustomer);
            CustomerOutputDTO resultDTO = new CustomerOutputDTO(result);
            return TypedResults.Created($"/{result.Id}", new Payload<CustomerOutputDTO>(resultDTO));
        }
    }
}
