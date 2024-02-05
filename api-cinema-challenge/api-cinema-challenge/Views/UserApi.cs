using api_cinema_challenge.Reposities.ScreeningRepo;
using api_cinema_challenge.Reposities.TicketRepo;
using api_cinema_challenge.Reposities.UserRepo;

using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using static api_cinema_challenge.Models.Payloads.TicketPayloads;
using static api_cinema_challenge.Models.Payloads.UserPayloads;

namespace api_cinema_challenge.Views
{
    public static class UserApi
    {



        public static void ConfigureUserApi(this WebApplication app)
        {
            var userGroup = app.MapGroup("/customers");
            userGroup.MapGet("/", GetAllUsers);
            //userGroup.MapGet("/{id}", GetUserById); <- does not exists in the req
            userGroup.MapPost("/", CreateUser);
            userGroup.MapPut("/{id}", UpdateUser);
            userGroup.MapDelete("/{id}", DeleteUser);

            userGroup.MapPost("/{user_id}/screenings/{screening_id}", BookTicket);
            userGroup.MapGet("/{user_id}/screenings/{screening_id}", GetAllTickets);
        }

        private static async Task<IResult> GetAllUsers(IUserRepository userRepository)
        {
            var result = await userRepository.GetAllUsers();
            if (result == null)
            {
                return TypedResults.NotFound("There are no users in the database");
            }
            var resultUserAllDetailsDTO = new List<UserAllDetailsDTO>();
            foreach (var user in result)
            {
                resultUserAllDetailsDTO.Add(new UserAllDetailsDTO(user));
            }
            var dataDTO = new UserListDataDTO(resultUserAllDetailsDTO, "success");
            return TypedResults.Ok(dataDTO);
    
        }

        private static async Task<IResult> CreateUser(UserPostPayload payload, IUserRepository userRepository)
        {
            if (payload.name == null || payload.name == "")
            {
                return TypedResults.BadRequest($"Username must be a non-empty value! You entered: {payload.name}");
            }
            if (payload.email == null || payload.email == "" || !payload.email.Contains("@"))
            {
                return TypedResults.BadRequest($"E-mail must be a non-empty value and cave a @: You entered: {payload.email}");
            }
            if (payload.phonenumber == null || payload.phonenumber == "")
            {
                return TypedResults.BadRequest($"Phonenumber must be a non-empty value! You entered: {payload.phonenumber}");
            }

            var result = await userRepository.CreateUser(payload.name, payload.email, payload.phonenumber);

            if (result == null)
            {
                return TypedResults.BadRequest();
            }
            return TypedResults.Created("/customers",new UserDataDTO(result, "success"));
        }

        private static async Task<IResult> UpdateUser(int id, UserPutPayload payload, IUserRepository userRepository)
        {
            if (payload.name == "")
            {
                return TypedResults.BadRequest("Updated username can not be of type empty");
            }
            if (payload.email == "" || !payload.email.Contains("@"))
            {
                return TypedResults.BadRequest("Updated e-mail can not be of type empty or miss an @");
            }
            if (payload.phonenumber == "")
            {
                return TypedResults.BadRequest("Updated phonenumber can not be of type empty");
            }
            var result = await userRepository.UpdateUser(id, payload.name, payload.email, payload.phonenumber);
            if (result == null)
            {
                return TypedResults.NotFound($"User with id: {id} could not be found");
            }
            return TypedResults.Created($"/customers/{id}", new UserDataDTO(result, "success"));
        }

        private static async Task<IResult> DeleteUser(int id, IUserRepository userRepository)
        {
            var result = await userRepository.DeleteUser(id);
            if ( result == null )
            {
                return TypedResults.NotFound($"User with id: {id} could not be found");
            }
            return TypedResults.Ok(new UserDataDTO(result, "success"));
            
        }

        private static async Task<IResult> BookTicket(IUserRepository userRepository, ITicketRepository ticketRepository, IScreeningRepository screeningRepository, int user_id, int screening_id, TicketPostPayload payload)
        {
            var user = await userRepository.GetUserById(user_id);
            var screening = await screeningRepository.GetScreeningById(screening_id);
            if (user == null)
            {
                return TypedResults.NotFound($"Could not find user with id {user_id}");
            }
            if (screening == null)
            {
                return TypedResults.NotFound($"Could not find screening with id {screening_id}");
            }

            var newTicket = new Ticket
            {
                UserId = user_id,
                ScreeningId = screening_id,
                SeatNumber = payload.num_seats,

                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            var savedTicket = await ticketRepository.SaveTicket(newTicket);
            if ( savedTicket == null )
            {
                return TypedResults.NotFound();
            }

            return TypedResults.Created("/", new TicketDataDTO(savedTicket, "success"));
            throw new NotImplementedException();
        }

        private static async Task<IResult> GetAllTickets(IUserRepository userRepository, ITicketRepository ticketRepository, IScreeningRepository screeningRepository, int user_id, int screening_id)
        {

            var user = await userRepository.GetUserById(user_id);
            if (user == null)
            {
                return TypedResults.NotFound($"Nu such user could be found");
            }
            var screening = await screeningRepository.GetScreeningById(screening_id);
            if ( screening == null )
            {
                return TypedResults.NotFound($"");
            }
            var result = await ticketRepository.GetAllTickets(user_id, screening_id);
            
         
            if ( result == null )
            {
                return TypedResults.NotFound($"There are no tickets currently in the database");
            }
            var ticketDTO = new List<TicketDTO>();
            foreach (var ticket in result)
            {
                ticketDTO.Add(new TicketDTO(ticket));
            }

            var ticketListDTO = new TicketListDataDTO(ticketDTO, "success");
            return TypedResults.Ok(ticketListDTO);
            
        }


    }
}
