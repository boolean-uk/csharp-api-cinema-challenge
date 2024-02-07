using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Infrastructure;
using api_cinema_challenge.Presentation.DTOs.Customers;
using api_cinema_challenge.Presentation.DTOs.Tickets;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

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

            // Tickets
            group.MapPost("/{customerId}/screenings/{screeningId}", AddTicket);
            group.MapGet("/{customerId}/screenings/{screeningId}", GetTicket);
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

        public async static Task<IResult> AddTicket(IRepository<Ticket> repository,
            [FromHeader(Name = "customerId")] int customerId,
            [FromHeader(Name = "screeningId")] int screeningId,
            [FromBody] AddTicketDTO ticketDTO, 
            IMapper mapper)
        {
            ServiceResponse<GetTicketDTO> response = new();
            try
            {
                Ticket ticket = new();
                ticket = mapper.Map<Ticket>(ticketDTO)!;
                ticket.ScreeningId = screeningId;
                ticket.CustomerId = customerId;
                ticket = await repository.Add(ticket);
                response.Data = mapper.Map<GetTicketDTO>(ticket);
                return TypedResults.Ok(response);
            } catch (ArgumentException ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.NotFound(response);
            }
        }

        public async static Task<IResult> GetTicket(IRepository<Ticket> repository,
            [FromHeader(Name = "customerId")] int customerId,
            [FromHeader(Name = "screeningId")] int screeningId,
            IMapper mapper)
        {
            ServiceResponse<List<GetTicketDTO>> response = new();
            try
            {
                List<Ticket> tickets = await repository.GetAll();
                List<GetTicketDTO> getTicketDTOs = tickets
                    .Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId)
                    .Select(mapper.Map<GetTicketDTO>)
                    .ToList()!;
                response.Data = getTicketDTOs;
                return TypedResults.Ok(response);
            } catch (ArgumentException ex)
            {
                response.Success = false;
                response.Message = ex.Message;
                return TypedResults.NotFound(response);
            }
        }
    }
}
