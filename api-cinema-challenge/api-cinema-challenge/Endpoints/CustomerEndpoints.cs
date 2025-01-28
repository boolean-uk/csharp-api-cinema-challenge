using api_cinema_challenge.DTO;
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
            var customers = app.MapGroup("/customers").WithTags("Customers"); ;

            customers.MapPost("/", Create);
            customers.MapGet("/", GetAll);
            customers.MapPut("/{id}", Update);
            customers.MapDelete("/{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Customer> repo, IMapper mapper, CustomerPost model)
        {
            try
            {
                var newEntity = new Customer()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                var createdEntity = await repo.Insert(newEntity);
                var dto = mapper.Map<CustomerDTO>(createdEntity);

                var payload = new Payload<CustomerDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Created($"/{createdEntity.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Customer> repo, IMapper mapper)
        {
            try
            {
                var entities = await repo.Get();
                var dtos = mapper.Map<List<CustomerDTO>>(entities);
                var payload = new Payload<List<CustomerDTO>>();
                payload.Status = "success";
                payload.Data = dtos;
                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Update(IRepository<Customer> repo, IMapper mapper, CustomerPut model, int id)
        {
            try
            {
                var entity = await repo.GetById(id);

                if (entity == null) return TypedResults.NotFound("Entity not found");

                if (model.Name != null) entity.Name = model.Name;
                if (model.Email != null) entity.Email = model.Email;
                if (model.Phone != null) entity.Phone = model.Phone;

                entity.UpdatedAt = DateTime.UtcNow;
                var updatedEntity = await repo.Update(entity);
                var dto = mapper.Map<CustomerDTO>(updatedEntity);

                var payload = new Payload<CustomerDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Created($"/{updatedEntity.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Delete(IRepository<Customer> repo, IMapper mapper, int id)
        {
            try
            {
                var entity = await repo.GetById(id);

                if (entity == null) return TypedResults.NotFound("Entity not found");

                var deletedEntity = await repo.Delete(id);
                var dto = mapper.Map<CustomerDTO>(deletedEntity);
                var payload = new Payload<CustomerDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Ok(payload);

            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }


    }
}

