using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app) 
        {
            var customers = app.MapGroup("customers");

            customers.MapGet("/", GetAllCustomers);
            customers.MapPost("/", CreateCustomer);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
            customers.MapGet("/{customerId}/screenings/{screeningId}", GetAllTicketsForScreeningById);
            customers.MapPost("/{customerId}/screenings/{screeningId}", CreateTicket);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> rep, IMapper mapper)
        {
            try
            {
                var customers = await rep.GetAll(null, null);

                var response = mapper.Map<ResponseDTO<CustomerDTO>>(customers);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }

        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> rep, IMapper mapper, CustomerPOST model)
        {
            try
            {
                var customer = mapper.Map<Customer>(model);

                await rep.Create(customer);

                var response = mapper.Map<ResponseSingleDTO<CustomerDTO>>(customer);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> rep, IMapper mapper, int id, CustomerPUT model)
        {

            try
            {
                var customer = await rep.GetById(id);
                if (customer == null) return TypedResults.NotFound("No customer with matching ID");

                customer = mapper.Map(model, customer);
                customer.UpdatedAt = DateTime.UtcNow;
                await rep.Update(customer);

                var response = mapper.Map<ResponseSingleDTO<CustomerDTO>>(customer);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> rep, IMapper mapper, int id)
        {
            try
            {
                var customer = await rep.GetById(id);
                if (customer == null) return TypedResults.NotFound("No customer with matching ID");

                await rep.Delete(customer);

                var response = mapper.Map<ResponseSingleDTO<CustomerDTO>>(customer);
                response.Status = "Successfully deleted";

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllTicketsForScreeningById(IRepository<Ticket> rep, int customerId, int screeningId, IMapper mapper)
        {
            try
            {
                var tickets = await rep.GetAll(customerId, screeningId);
                if (tickets == null) return TypedResults.NotFound("No matching tickets found");

                var response = mapper.Map<ResponseDTO<TicketDTO>>(tickets);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> rep, IMapper mapper, int customerId, int screeningId, TicketPOST model)
        {
            try
            {
                var ticket = mapper.Map<Ticket>(model);
                ticket.CustomerId = customerId;
                ticket.ScreeningId = screeningId;

                await rep.Create(ticket);

                var response = mapper.Map<ResponseSingleDTO<TicketDTO>>(ticket);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }

        }
    }
}

