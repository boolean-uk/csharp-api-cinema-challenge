using api_cinema_challenge.DTOs;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints;

public static class CustomerEndpoint
{
    public static void ConfigureCustomerEndpoint(this IEndpointRouteBuilder routes)
    {
        var group = routes
            .MapGroup("/customers")
            .WithTags("Customers")
            .WithSummary("Customers API")
            .WithDescription("This API allows you to manage customers at the cinema.")
            .WithOpenApi();

        group.MapGet("/", GetCustomers)
            .WithName("GetCustomers")
            .WithSummary("Get all customers.")
            .WithDescription("Retrieves all customers from the cinema database.")
            .Produces<IEnumerable<CustomerGetDto>>(StatusCodes.Status200OK);

        group.MapPut("/", PostCustomer)
            .WithName("PostCustomer")
            .WithSummary("Create a new customer.")
            .WithDescription("Creates a new customer in the cinema database.")
            .Accepts<CustomerPostDto>("application/json")
            .Produces<CustomerGetDto>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

        group.MapPut("/{id:int}", UpdateCustomer)
            .WithName("UpdateCustomer")
            .WithSummary("Update a customer.")
            .WithDescription("Updates a customer in the cinema database.")
            .Accepts<CustomerUpdateDto>("application/json")
            .Produces<CustomerGetDto>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

        group.MapDelete("/{id:int}", DeleteCustomer)
            .WithName("DeleteCustomer")
            .WithSummary("Delete a customer.")
            .WithDescription("Deletes a customer from the cinema database.")
            .Produces<CustomerGetDto>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

        group.MapPost("/{customerId:int}/screenings/{screeningId:int}", BookTicket)
            .WithName("BookTicket")
            .WithSummary("Book a ticket for a customer.")
            .WithDescription("Books a ticket for a customer for a specific screening.")
            .Accepts<NumSeatsDto>("application/json")
            .WithTags("Ticket")
            .Produces<TicketGetDto>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest);

        group.MapGet("/{customerId:int}/screenings/{screeningId:int}", GetTickets)
            .WithName("GetTickets")
            .WithSummary("Get all tickets for a customer and screening.")
            .WithTags("Ticket")
            .Produces<IEnumerable<TicketGetDto>>(StatusCodes.Status201Created);
    }

    private static async Task<IResult> GetTickets(ICustomerRepository repository, int customerId, int screeningId)
    {
        return TypedResults.Ok(await repository.GetTickets(customerId, screeningId));
    }
    
    private static async Task<IResult> BookTicket(ICustomerRepository repository, NumSeatsDto numSeats, int customerId, int screeningId)
    {
        return TypedResults.Created($"/customers/{customerId}/screenings/{screeningId}", await repository.BookTicket(customerId, screeningId, numSeats));
    }

    private static async Task<IResult> GetCustomers(ICustomerRepository repository)
    {
        return TypedResults.Ok(await repository.GetCustomers());
    }

    private static async Task<IResult> PostCustomer(ICustomerRepository repository, CustomerPostDto cpd)
    {
        try
        {
            var c = await repository.PostCustomer(cpd);
            return TypedResults.Created($"/customers/", c);
        }
        catch (ArgumentException e)
        {
            return TypedResults.BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return TypedResults.BadRequest(e.Message);
        }
    }

    private static async Task<IResult> UpdateCustomer(ICustomerRepository repository, int id, CustomerUpdateDto cud)
    {
        try
        {
            var c = await repository.UpdateCustomer(id, cud);
            return TypedResults.Ok(c);
        }
        catch (ArgumentException e)
        {
            return TypedResults.BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return TypedResults.BadRequest(e.Message);
        }
    }

    private static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int id)
    {
        try
        {
            var c = await repository.DeleteCustomer(id);
            return TypedResults.Ok(c);
        }
        catch (ArgumentException e)
        {
            return TypedResults.BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return TypedResults.BadRequest(e.Message);
        }
    }
}