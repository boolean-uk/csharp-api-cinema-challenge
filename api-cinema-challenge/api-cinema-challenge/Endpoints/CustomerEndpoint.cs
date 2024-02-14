using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.DTO.Entities.SalesAndTickets;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Repository.Specific;
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
            group.MapPost("/{customerId}/screenings/{screeningId}", CreateTicketForScreening);
            group.MapGet("/{customerId}/screenings/{screeningId}", GetTicketsForScreening);
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

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTicketsForScreening(
            [FromServices] IRepository<Customer> customerRepository,
            [FromServices] IRepository<Ticket> ticketRepository,
            [FromServices] IScreeningRepository screeningRepository,
            [FromServices] IJunctionRepository<ScreeningSeat> screeningSeatRepository,
            [FromRoute] int customerId,
            [FromRoute] int screeningId)
        {
            Customer? customer = await customerRepository.GetById(customerId);
            if (customer == null) return TypedResults.NotFound($"No customer with id={customerId}");
            Screening? screening = await screeningRepository.GetById(screeningId);
            if (screening == null) return TypedResults.NotFound($"No screening with id={screeningId}");
            List<TicketOutputDTO> resultDTOs = new List<TicketOutputDTO>();
            foreach (Ticket ticket in customer.Tickets)
            {
                if (ticket.ScreeningSeats.Any(s => s.ScreeningId == screening.Id)) resultDTOs.Add(new TicketOutputDTO(ticket));
            }
            return TypedResults.Ok(new Payload<List<TicketOutputDTO>>(resultDTOs));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateTicketForScreening(
            [FromServices] IRepository<Customer> customerRepository,
            [FromServices] IRepository<Ticket> ticketRepository,
            [FromServices] IScreeningRepository screeningRepository,
            [FromServices] IJunctionRepository<ScreeningSeat> screeningSeatRepository,
            [FromBody] TicketInputDTO input,
            [FromRoute] int customerId,
            [FromRoute] int screeningId)
        {
            Customer? customer = await customerRepository.GetById(customerId);
            if (customer == null) return TypedResults.NotFound($"No customer with id={customerId}");
            Screening? screening = await screeningRepository.GetById(screeningId);
            if (screening == null) return TypedResults.NotFound($"No screening with id={screeningId}");
            if (screening.ScreeningSeats.Where(s => s.TicketId == null).Count() < input.NumSeats) return TypedResults.BadRequest("Not enough available seats.");
            Ticket newTicket = await ticketRepository.Insert(new Ticket() { CustomerId = customerId });
            for (int i = 0; i < input.NumSeats; i++)
            {
                ScreeningSeat seat = screening.ScreeningSeats.FirstOrDefault(ss => ss.TicketId == null);
                seat.TicketId = newTicket.Id;
                seat.UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
                ScreeningSeat result = await screeningSeatRepository.Update(seat);
            }
            newTicket = await ticketRepository.GetById(newTicket.Id);
            TicketOutputDTO resultDTO = new TicketOutputDTO(newTicket);
            return TypedResults.Created($"/{customerId}/screenings/{screeningId}", new Payload<TicketOutputDTO>(resultDTO));
        }
    }
}
