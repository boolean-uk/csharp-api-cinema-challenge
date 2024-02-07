using api_cinema_challenge.Models.DTO.CustomerDTOs;
using api_cinema_challenge.Models.DTO.MovieDTOs;
using api_cinema_challenge.Models.DTO.TicketDTOs;
using api_cinema_challenge.Models.Other;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            RouteGroupBuilder customerGroup = app.MapGroup("customers");
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
            customerGroup.MapPost("/{id}/screenings/{screeningid}", CreateTicket);
            customerGroup.MapGet("/{id}/screenings/{screeningid}", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(CreateCustomerDTO cDTO, ICustomerRepository repository)
        {
            GetCustomerDTO? result = await repository.CreateCustomer(cDTO);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Invalid input for creating a customer." };
                return TypedResults.BadRequest(errorResponse);
            }
            ApiResponseType<GetCustomerDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Created("", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            List<GetCustomerDTO> result = await repository.GetCustomers();
            ApiResponseType<List<GetCustomerDTO>> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(int id, CreateCustomerDTO uDTO, ICustomerRepository repository)
        {
            GetCustomerDTO? result = await repository.UpdateCustomer(id, uDTO);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Could not find customer with id: {id}" };
                return TypedResults.NotFound(errorResponse);
            }
            ApiResponseType<GetCustomerDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(int id, ICustomerRepository repository)
        {
            GetCustomerDTO? result = await repository.DeleteCustomer(id);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Could not find customer with id: {id}" };
                return TypedResults.NotFound(errorResponse);
            }
            ApiResponseType<GetCustomerDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateTicket(int id, int screeningid, CreateTicketDTO cDTO, ICustomerRepository repository)
        {
            GetTicketDTO? result = await repository.CreateTicket(id, screeningid, cDTO);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Invalid input for creating a ticket." };
                return TypedResults.BadRequest(errorResponse);
            }
            ApiResponseType<GetTicketDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Created("", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(int id, int screeningid, ICustomerRepository repository)
        {
            List<GetTicketDTO> result = await repository.GetTickets(id, screeningid);
            ApiResponseType<List<GetTicketDTO>> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }
    }
}
