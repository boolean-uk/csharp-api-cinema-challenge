using api_cinema_challenge.DTOs.Custommer;
using api_cinema_challenge.DTOs.Ticket;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ServiceResponse;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace api_cinema_challenge.Endpoints
{
    public static class CustommerEndpoints
    {
        public static void ConfigureCustommerEndpoint(this WebApplication app)
        {
            var custommerGroup = app.MapGroup("custommers");

            custommerGroup.MapGet("/", GetCustommers);
            custommerGroup.MapPost("/", CreateCustommer);
            custommerGroup.MapPut("/{id}", UpdateCustommer);
            custommerGroup.MapDelete("/{id}", DeleteCustommer);



        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustommers(IRepository repository)
        {

            //Soruce:
            var source = await repository.GetCustommers();

            //Target & Transferring:

            List<OutCustommerDTO> outData = source.Select(c => new OutCustommerDTO
            {
                Id = c.Id,
                Email = c.Email,
                Name = c.Name,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                Tickets = c.Tickets.Select(t => new OutTicketDTO { Id = t.Id, CreatedAt = t.CreatedAt, UpdatedAt = t.UpdatedAt, SeatNumber = t.SeatNumber }).ToList()

            }).ToList();

            // Use the wrapper class to create a consisten response:
            var response = new ServiceResponse<List<OutCustommerDTO>>
            {
                Data = outData,
                Status = "Success"
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustommer(IRepository repository, [FromBody] InCustommerDTO newCustommer)
        {
            try
            {
                //Soruce:
                Custommer source = await repository.AddCustommer(newCustommer);

                // Transferring:
                OutCustommerDTO outData = new OutCustommerDTO
                {
                    Id = source.Id,
                    Email = source.Email,
                    Name = source.Name,
                    Phone = source.Phone,
                    CreatedAt = source.CreatedAt,
                    UpdatedAt = source.UpdatedAt
                };

                //Reponse:
                var response = new ServiceResponse<OutCustommerDTO>
                {
                    Data = outData,
                    Status = "Success"
                };

                return TypedResults.Created(nameof(CreateCustommer), response);
            }

            catch (BadHttpRequestException ex)
            {//Reponse:
                var response = new ServiceResponse<InCustommerDTO>
                {
                    Data = newCustommer,
                    Status = "Unsuccess"
                };

                return TypedResults.BadRequest(response);
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustommer(IRepository repository, int id, [FromBody] InCustommerDTO newCustommer)
        {

            try
            {
                // Source:
                Custommer source = await repository.UpdateCustommer(id, newCustommer);
                // Transferring:
                OutCustommerDTO outData = new OutCustommerDTO
                {
                    Id = source.Id,
                    Email = source.Email,
                    Name = source.Name,
                    Phone = source.Phone,
                    CreatedAt = source.CreatedAt,
                    UpdatedAt = source.UpdatedAt
                };

                //Reponse:
                var response = new ServiceResponse<OutCustommerDTO>
                {
                    Data = outData,
                    Status = "Success"
                };

                return TypedResults.Created(nameof(CreateCustommer), response);

            }

            catch (Exception ex)
            {

                var response = new ServiceResponse<InCustommerDTO>
                {
                    Data = newCustommer,
                    Status = "Unsuccess"
                };

                return TypedResults.NotFound(response);

            }

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustommer(IRepository repository, int id)
        {
            try
            {
                // Source:
                Custommer source = await repository.DeleteCustommer(id);

                // Transferring:
                OutCustommerDTO outData = new OutCustommerDTO
                {
                    Id = source.Id,
                    Email = source.Email,
                    Name = source.Name,
                    Phone = source.Phone,
                    CreatedAt = source.CreatedAt,
                    UpdatedAt = source.UpdatedAt
                };

                //Reponse:
                var response = new ServiceResponse<OutCustommerDTO>
                {
                    Data = outData,
                    Status = "Success"
                };

                return TypedResults.Ok(response);

            }

            catch (Exception ex)
            {
                var response = new ServiceResponse<InCustommerDTO>
                {

                    Status = "Unsuccess"
                };

                return TypedResults.NotFound(response);
            }
        }



    }
}
