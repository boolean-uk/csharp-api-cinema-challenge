using api_cinema_challenge.DTOs.Customer;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerAPI
    {
        
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customers = app.MapGroup("/customers");
            customers.MapGet("", GetAllCustomers);
            customers.MapGet("/{id}", GetACustomer);
            customers.MapPost("", CreateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
            customers.MapPut("/{id}", UpdateCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRepository customerRepository)
        {
            try
            {
                var result = await customerRepository.GetAllCustomers();

                List<GetCustomerDTO> customerDTOs = new List<GetCustomerDTO>();

                foreach (var customer in result)
                {

                    List<GetTicketForCustomerDTO> tickets = new List<GetTicketForCustomerDTO>();

                    foreach (var ticket in customer.Tickets)
                    {
                        GetTicketForCustomerDTO ticketDTO = new GetTicketForCustomerDTO();
                        ticketDTO.Id = ticket.Id;
                        ticketDTO.ScreeningId = ticket.ScreeningId;
                        ticketDTO.ScreenNumber = ticket.Screening.ScreenNumber;
                        ticketDTO.NumSeats = ticket.NumSeats;
                        ticketDTO.MovieTitle = ticket.Screening.Movie.Title;
                        ticketDTO.CreatedAt = ticket.CreatedAt;
                        ticketDTO.UpdatedAt = ticket.UpdatedAt;

                        tickets.Add(ticketDTO);
                    }

                    GetCustomerDTO customerDTO = new GetCustomerDTO()
                    {
                        Id = customer.Id,
                        Name = customer.Name,
                        Email = customer.Email,
                        Phone = customer.Phone,
                        CreatedAt = customer.CreatedAt,
                        UpdatedAt = customer.UpdatedAt,
                        Tickets = tickets
                    };

                    customerDTOs.Add(customerDTO);
                }

                Payload<IEnumerable<GetCustomerDTO>> payload = new Payload<IEnumerable<GetCustomerDTO>>();
                payload.data = customerDTOs;
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);

            }
            catch (Exception ex)
            {

                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetACustomer(ICustomerRepository customerRepository, int id)
        {
            try
            {

                var result = await customerRepository.GetCustomerById(id);

                List<GetTicketForCustomerDTO> tickets = new List<GetTicketForCustomerDTO>();

                foreach (var ticket in result.Tickets)
                {
                    GetTicketForCustomerDTO ticketDTO = new GetTicketForCustomerDTO();
                    ticketDTO.Id = ticket.Id;
                    ticketDTO.ScreeningId = ticket.ScreeningId;
                    ticketDTO.ScreenNumber = ticket.Screening.ScreenNumber;
                    ticketDTO.NumSeats = ticket.NumSeats;
                    ticketDTO.MovieTitle = ticket.Screening.Movie.Title;
                    ticketDTO.CreatedAt = ticket.CreatedAt;
                    ticketDTO.UpdatedAt = ticket.UpdatedAt;

                    tickets.Add(ticketDTO);
                }

                GetCustomerDTO customerDTO = new GetCustomerDTO()
                {
                    Id = result.Id,
                    Name = result.Name,
                    Email = result.Email,
                    Phone = result.Phone,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt,
                    Tickets = tickets
                };

                Payload<GetCustomerDTO> payload = new Payload<GetCustomerDTO>();
                payload.data = customerDTO;
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);

            }
            catch (Exception)
            {
                return TypedResults.NotFound($"Customer with id {id} not found!");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository customerRepository, PostPutCustomerDTO newCustomer)
        {
            try
            {

                Customer customer = new Customer()
                {
                    Name = newCustomer.Name,
                    Email = newCustomer.Email,
                    Phone = newCustomer.Phone,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                var result = await customerRepository.CreateCustomer(customer);

                List<GetTicketForCustomerDTO> tickets = new List<GetTicketForCustomerDTO>();

                foreach (var ticket in result.Tickets)
                {
                    GetTicketForCustomerDTO ticketDTO = new GetTicketForCustomerDTO();
                    ticketDTO.Id = ticket.Id;
                    ticketDTO.ScreeningId = ticket.ScreeningId;
                    ticketDTO.ScreenNumber = ticket.Screening.ScreenNumber;
                    ticketDTO.NumSeats = ticket.NumSeats;
                    ticketDTO.MovieTitle = ticket.Screening.Movie.Title;
                    ticketDTO.CreatedAt = ticket.CreatedAt;
                    ticketDTO.UpdatedAt = ticket.UpdatedAt;

                    tickets.Add(ticketDTO);
                }

                GetCustomerDTO customerDTO = new GetCustomerDTO()
                {
                    Id = result.Id,
                    Name = result.Name,
                    Email = result.Email,
                    Phone = result.Phone,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt,
                    Tickets = tickets
                };

                Payload<GetCustomerDTO> payload = new Payload<GetCustomerDTO>();
                payload.data = customerDTO;
                payload.status = System.Net.HttpStatusCode.Created;
                var path = $"/customers/{result.Id}";

                return TypedResults.Created(path, payload);

            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository customerRepository, int id)
        {
            try
            {
                await customerRepository.DeleteCustomer(id);
                return TypedResults.Ok($"Customer with id {id} deleted!");
            }
            catch (Exception)
            {
                return TypedResults.NotFound($"Customer with id {id} not found!");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository customerRepository, int id, PostPutCustomerDTO newValues)
        {
            try
            {
                var target = await customerRepository.GetCustomerById(id);

                if (target == null)
                {
                    return TypedResults.NotFound($"Customer with id {id} not found!");
                }

                Customer updatedCustomer = new Customer()
                {
                    Name = newValues.Name,
                    Email = newValues.Email,
                    Phone = newValues.Phone,
                    UpdatedAt = DateTime.UtcNow
                };

                var result = await customerRepository.UpdateCustomer(id, updatedCustomer);

                List<GetTicketForCustomerDTO> tickets = new List<GetTicketForCustomerDTO>();

                foreach (var ticket in result.Tickets)
                {
                    GetTicketForCustomerDTO ticketDTO = new GetTicketForCustomerDTO();
                    ticketDTO.Id = ticket.Id;
                    ticketDTO.ScreeningId = ticket.ScreeningId;
                    ticketDTO.ScreenNumber = ticket.Screening.ScreenNumber;
                    ticketDTO.NumSeats = ticket.NumSeats;
                    ticketDTO.MovieTitle = ticket.Screening.Movie.Title;
                    ticketDTO.CreatedAt = ticket.CreatedAt;
                    ticketDTO.UpdatedAt = ticket.UpdatedAt;

                    tickets.Add(ticketDTO);
                }

                GetCustomerDTO customerDTO = new GetCustomerDTO()
                {
                    Id = result.Id,
                    Name = result.Name,
                    Email = result.Email,
                    Phone = result.Phone,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt,
                    Tickets = tickets
                };

                Payload<GetCustomerDTO> payload = new Payload<GetCustomerDTO>();
                payload.data = customerDTO;
                payload.status = System.Net.HttpStatusCode.Created;
                var path = $"/customers/updated/{result.Id}";

                return TypedResults.Created(path, payload);

            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
