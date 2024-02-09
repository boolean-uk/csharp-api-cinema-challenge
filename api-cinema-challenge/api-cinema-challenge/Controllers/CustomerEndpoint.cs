using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.PostModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using api_cinema_challenge.Models.DTO;

namespace api_cinema_challenge.Controllers
{

    public static class CustomerEndpoint {

        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", AllCustomers);
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapPut("/{id}", EditCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
        }

    
         [ProducesResponseType(StatusCodes.Status200OK)]
         public static async Task<IResult> AllCustomers(IRepository<Customer> repository)
         {
            DTO result = new DTO();
            var customers = await repository.GetAll();
            foreach (Customer customer in customers) {
                result.createDtCustomer(customer);
            }
            PayLoad<IEnumerable<DtCustomer>> pl = new PayLoad<IEnumerable<DtCustomer>>(result.Customers);
            return TypedResults.Ok(pl);
         }

        [ProducesResponseType(StatusCodes.Status201Created)]
         public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, PMCustomer model)
         {
            DTO result = new DTO();
            result.createDtCustomer(await repository.Insert(new Customer() { Name = model.Name, Email = model.Email, Phone = model.Phone }));

            PayLoad<DtCustomer> pl = new PayLoad<DtCustomer>(result.Customer);
            return TypedResults.Created($"/{pl}", pl);
         }

         [ProducesResponseType(StatusCodes.Status201Created)]
         public static async Task<IResult> EditCustomer(IRepository<Customer> repository, int id, PMCustomer model)
         {
            DTO result = new DTO();
            result.createDtCustomer(await repository.Update(new Customer() { Id = id, Name = model.Name, Phone = model.Phone, Email = model.Email }));
            PayLoad<DtCustomer> pl = new PayLoad<DtCustomer>(result.Customer);
            return TypedResults.Created($"/{pl}", pl);
         }

             [ProducesResponseType(StatusCodes.Status200OK)]
         public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
         {
            DTO result = new DTO();
            result.createDtCustomer(await repository.Delete(id));
            PayLoad<DtCustomer> pl = new PayLoad<DtCustomer>(result.Customer);
            return TypedResults.Ok(pl);
         }

    }
}
