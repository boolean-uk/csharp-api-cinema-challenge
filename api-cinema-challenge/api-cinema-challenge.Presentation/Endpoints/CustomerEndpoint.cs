using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Infrastructure;
using api_cinema_challenge.Presentation.DTOs.Customers;
using AutoMapper;

namespace api_cinema_challenge.Presentation.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("/customers");

            group.MapGet("/{id}", Get);
            group.MapGet("/", GetAll);
            group.MapPost("/", Add);
            group.MapDelete("/{id}", Delete);
            group.MapPut("/{id}", Put);
        }

        public async static Task<IResult> Get(IRepository<Customer> repository, int id, IMapper mapper)
        {
            ServiceResponse<GetCustomerDTO> response = new();
            try
            {
                Customer customer = await repository.GetById(id);
                response.Data = mapper.Map<GetCustomerDTO>(customer);
                return TypedResults.Ok(response);
            } catch (ArgumentException ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.NotFound(response);
            }
        }

        public async static Task<IResult> GetAll(IRepository<Customer> repository, IMapper mapper)
        {
            ServiceResponse<List<GetCustomerDTO>> response = new();
            try
            {
                List<Customer> customers = await repository.GetAll();
                response.Data = customers.Select(mapper.Map<GetCustomerDTO>).ToList()!;
                return TypedResults.Ok(response);
            } catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.BadRequest(response);
            }
        }

        public async static Task<IResult> Add(IRepository<Customer> repository, AddCustomerDTO customerDTO, IMapper mapper)
        {
            ServiceResponse<GetCustomerDTO> response = new();
            try
            {
                Customer customer = new()
                {
                    Email = customerDTO.Email,
                    Name = customerDTO.Name,
                    Phone = customerDTO.Phone,
                };
                customer = await repository.Add(customer);
                response.Data = mapper.Map<GetCustomerDTO>(customer);
                return TypedResults.Created(nameof(Add), response);
            } catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.BadRequest(response);
            }
        }

        public async static Task<IResult> Delete(IRepository<Customer> repository, int id, IMapper mapper)
        {
            ServiceResponse<GetCustomerDTO> response = new();
            try
            {
                Customer customer = await repository.DeleteById(id);
                response.Data = mapper.Map<GetCustomerDTO>(customer);
                return TypedResults.Ok(response);
            } catch (ArgumentException ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.NotFound(response);
            }
        }

        public async static Task<IResult> Put(IRepository<Customer> repository, AddCustomerDTO customerDTO, int id, IMapper mapper)
        {
            ServiceResponse<GetCustomerDTO> response = new();
            try
            {
                Customer customer = await repository.GetById(id);
                customer.Phone = customerDTO.Phone;
                customer.Name = customerDTO.Name;
                customer.Email = customerDTO.Email;
                response.Data = mapper.Map<GetCustomerDTO>(customer);
                return TypedResults.Ok(response);
            }
            catch (ArgumentException ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.NotFound(response);
            }
        }
    }
}
