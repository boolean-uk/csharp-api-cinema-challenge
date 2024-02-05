using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.DTO_Customer;
using api_cinema_challenge.DTO.DTO_Ticket;
using api_cinema_challenge.Reposetories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPut("/{customerId}", UpdateCustomer);
            customerGroup.MapDelete("/{customerId}", DeleteCustomer);
            customerGroup.MapPost("/{customerId}/screenings/{screeningId}", BookATicket);
            //customerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetAllCustomersTicketsPerScreaning);
        }


        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPayload customerPayload)
        {
            if(customerPayload.name == null || customerPayload.name == string.Empty)
            {
                return TypedResults.NotFound("not a valid name");
            }
            if (customerPayload.email == null || customerPayload.email == string.Empty)
            {
                return TypedResults.NotFound("not a valid email");
            }
            if (customerPayload.phoneNumber == null || customerPayload.phoneNumber == string.Empty)
            {
                return TypedResults.NotFound("not a valid phone number");
            }

            var result = await repository.CreateCustomer(
                customerPayload.name,
                customerPayload.email,
                customerPayload.phoneNumber
                );

            CustomerDTO customerDTO = new CustomerDTO(result);
            CustomerBaseDTO baseDTO = new CustomerBaseDTO(customerDTO); 

            return TypedResults.Ok(baseDTO);

        }
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            var results = await repository.GetCustomers();

            if(results == null)
            {
                return TypedResults.NotFound("something went wrong");
            }
            else
            {
                var dto = new List<CustomerBaseDTO>();
                foreach( var result in results) 
                {
                    var customerDTO = new CustomerDTO(result);
                    CustomerBaseDTO baseDTO = new CustomerBaseDTO(customerDTO);

                    dto.Add(baseDTO);
                }

                return TypedResults.Ok(dto);    
            }
        }

        private static async Task<IResult> UpdateCustomer(IRepository repository,int id, CustomerUpdateData updateData)
        {
            

            if(id <= 0)
            {
                return TypedResults.BadRequest("id needs to be a positive integer above 0");
            }
            if (updateData.name == null || updateData.name == string.Empty)
            {
                return TypedResults.BadRequest("not a valid name");
            }
            if (updateData.email == null || updateData.email == string.Empty)
            {
                return TypedResults.BadRequest("not a valid email");
            }
            var trimmedString = updateData.email.Trim();
            if (trimmedString.EndsWith("."))
            {
                return TypedResults.BadRequest("not a valid email");
            }
            try
            {
                var email = new System.Net.Mail.MailAddress(updateData.email);
                if(email.Address != trimmedString)
                {
                    return TypedResults.BadRequest("not a valid email");
                }
            }
            catch
            {
                return TypedResults.BadRequest("not a valid email");
            }
            if (updateData.phoneNumber == null || updateData.phoneNumber == string.Empty)
            {
                return TypedResults.BadRequest("not a valid phone number");
            }


            var customer  = await repository.UpdateCustomer(id,updateData.name, updateData.email, updateData.phoneNumber);

            if(customer == null)
            {
                return TypedResults.NotFound("id was not a valid id");
            }
            else
            {
                var customerDTO = new CustomerDTO(customer);
                CustomerBaseDTO baseDTO = new CustomerBaseDTO(customerDTO);

                return TypedResults.Ok(baseDTO);

                
            }
        }

        

        private static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            if (id <= 0)
            {
                return TypedResults.BadRequest("id needs to be a positive integer above 0");
            }

            var customer = await repository.DeleteCustomer(id);


            if (customer == null)
            {
                return TypedResults.NotFound("id was not a valid id");
            }
            else
            {
                var customerDTO = new CustomerDTO(customer);

                CustomerBaseDTO baseDTO = new CustomerBaseDTO(customerDTO);

                return TypedResults.Ok(baseDTO);
            }
        }

        private static async Task<IResult> BookATicket(IRepository repository, int customerId, int screeningId,TicketPayload payload)
        {
            if (customerId <= 0 || screeningId <= 0) 
            {
                return TypedResults.BadRequest("both customer Id and screening Id need to be positive integers above 0");
            }
            if(payload.numSeats <= 0)
            {
                return TypedResults.BadRequest("you must have at least 1 seat booked (numSeats can not be an integer of 0 or below)");
            }

            var result = await repository.BookATicket(customerId, screeningId, payload.numSeats);

            if (result == null) 
            {
                return TypedResults.NotFound("invalid customer or screening ID");
            }
            else
            {
                var ticketDTO = new TicketDTO(result);
                TicketBaseDTO baseDTO = new TicketBaseDTO(ticketDTO);
                return TypedResults.Ok(baseDTO);
            }
        }

    }
}
