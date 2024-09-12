using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            //customers.MapPost("/", CreateCustomer);
            //customers.MapGet("/", GetCustomers);
            //customers.MapGet("/{id}", GetCustomerById);
            //customers.MapPut("/{id}", UpdateCustomer);
            //customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, PostCustomerDTO model)
        {
            try
            {
                var result = await repository.Add(new Author() { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email });
                var target = await repository.GetById(result.Id);
                AuthorEndpointResponseAuthor responseAuthor = MakeResponseAuthorDTO(target);
                return TypedResults.Created($"https://localhost:7054/authors/{responseAuthor.Id}", responseAuthor);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest("Invalid author object");
            }
        }
    }
}
