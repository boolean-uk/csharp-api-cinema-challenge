using api_cinema_challenge.Controllers;
using api_cinema_challenge.DTO;

namespace api_cinema_challenge.Views
{
    public static class UserApi
    {

        public record UserPostPayload(string name, string email, string phonenumber);
        public record UserPutPayload(string? name, string? email, string? phonenumber);

        public static void ConfigureUserApi(this WebApplication app)
        {
            var userGroup = app.MapGroup("/customers");
            userGroup.MapGet("/", GetAllUsers);
            //userGroup.MapGet("/{id}", GetUserById); <- does not exists in the req
            userGroup.MapPost("/", CreateUser);
            userGroup.MapPut("/{id}", UpdateUser);
            userGroup.MapDelete("/{id}", DeleteUser);
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

            return TypedResults.Ok(resultUserAllDetailsDTO);
            throw new NotImplementedException();    
        }

        private static async Task<IResult> CreateUser(UserPostPayload payload, IUserRepository userRepository)
        {
            if (payload.name == null || payload.name == "")
            {
                return TypedResults.BadRequest($"Username must be a non-empty value! You entered: {payload.name}");
            }
            if (payload.email == null || payload.email == "")
            {
                return TypedResults.BadRequest($"E-mail must be a non-empty value! You entered: {payload.email}");
            }
            if (payload.phonenumber == null || payload.phonenumber == "")
            {
                return TypedResults.BadRequest($"Phonenumber must be a non-empty value! You entered: {payload.phonenumber}");
            }

            var result = userRepository.CreateUser(payload.name, payload.email, payload.phonenumber);

            throw new NotImplementedException();
        }

        private static async Task<IResult> UpdateUser(int id, UserPutPayload payload, IUserRepository userRepository)
        {


            throw new NotImplementedException();
        }

        private static async Task<IResult> DeleteUser(int id)
        {

            throw new NotImplementedException();
        }


    }
}
