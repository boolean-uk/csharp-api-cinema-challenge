//using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customer = app.MapGroup("customers");

            customer.MapGet("/", GetAll);
            customer.MapPost("/", Create);
            customer.MapPut("/{id}", Update);
            customer.MapDelete("/{id}", Delete);

        }

        private static CustomerGet CustomerToCustomerGet(Customer c)
        {
            CustomerGet customerShow = new CustomerGet() {Id = c.Id, Name = c.Name, Email = c.Email, Phone = c.Phone, CreatedAt = c.CreatedAt, UpdatedAt = c.UpdatedAt };
            return customerShow;
        }

        [Authorize(Roles = "Admin,User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Customer> customerRepo) {
            List<CustomerGet> response = new List<CustomerGet>();
            var results = await customerRepo.GetAll();
            foreach (Customer c in results) {
                CustomerGet customerShow = CustomerToCustomerGet(c);
                response.Add(customerShow);
            }
            return TypedResults.Ok(response);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Customer> customerRepo, CustomerPost cModel)
        {
            DateTime time = DateTime.UtcNow.ToUniversalTime();
            Customer newCustomer = new Customer() { 
                Name = cModel.Name, 
                Email = cModel.Email, 
                Phone = cModel.Phone,
                CreatedAt = time,
                UpdatedAt = time
            };
            await customerRepo.Insert(newCustomer);
            return TypedResults.Created($"Created object with id: {newCustomer.Id}");
        }

        [Authorize(Roles = "Admin,User")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Update(IRepository<Customer> customerRepo, int id, CustomerPost cModel)
        {
            Customer? cTarget = await customerRepo.GetById(id);
            if(cTarget!= null)
            {
                DateTime UpdatedTime = DateTime.UtcNow.ToUniversalTime();
                cTarget.Name = cModel.Name;
                cTarget.Email = cModel.Email;
                cTarget.Phone = cModel.Phone;
                cTarget.UpdatedAt = UpdatedTime;

                await customerRepo.Update(cTarget);
                return TypedResults.Created($"Updated object with id: {id}");
            }
            return TypedResults.NotFound();
        }

        [Authorize(Roles = "Admin,User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Delete(IRepository<Customer> customerRepo, int id)
        {
            Customer? cTarget = await customerRepo.GetById(id);
            if (cTarget != null)
            {
                await customerRepo.Delete(id);
                return TypedResults.Ok(CustomerToCustomerGet(cTarget));
            }
            return TypedResults.NotFound();
        }
    }
}
