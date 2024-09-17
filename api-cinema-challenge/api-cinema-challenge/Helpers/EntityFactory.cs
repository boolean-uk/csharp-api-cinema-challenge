using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using System.Security.Cryptography.Xml;

namespace api_cinema_challenge.Helpers
{
    public static class TransformDTO
    {
        public static Customer ToCustomer(PostCustomerDTO DTOobject)
        {
            Customer customer = new()
            {

                Name = DTOobject.Name,
                Email = DTOobject.Email,
                Phone = DTOobject.Phone,
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            };

            return customer;

        }
        public static GetCustomerDTO ToCustomerDTO(Customer customer)
        {
            GetCustomerDTO DTOobject = new()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                createdAt = customer.createdAt,
                updatedAt = customer.updatedAt
            };

            return DTOobject;
        }
        public static Customer ForCustomerUpdate(PostCustomerDTO DTOobject)
        {
            Customer customer = new()
            {

                Name = DTOobject.Name,
                Email = DTOobject.Email,
                Phone = DTOobject.Phone,
                updatedAt = DateTime.UtcNow
            };

            return customer;
        }
        public static Movie ToMovie(PostMovieDTO movieDTO)
        {
            Movie movie = new()
            {
                Title = movieDTO.Title,
                Rating = movieDTO.Rating,
                Description = movieDTO.Description,
                RuntimeMins = movieDTO.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            return movie;
        }

        public static Screening ToScreeningFromMovie(PostMovieDTO movieDTO, int movieId)
        {
            Screening screening = new()
            {
                MovieId = movieId,
                Capacity = movieDTO.Screening.capacity,
                ScreenNumber = movieDTO.Screening.screenNumber,
                StartsAt = movieDTO.Screening.startsAt,
            };

            return screening;
        }
        public static Screening ToScreening(PostScreeningDTO screeningDTO, int movieId)
        {
            Screening screening = new()
            {
                MovieId = movieId,
                Capacity = screeningDTO.capacity,
                ScreenNumber = screeningDTO.screenNumber,
                StartsAt = screeningDTO.startsAt,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            };
            return screening;
        }
        public static GetMovieDTO ToMovieDTO(Movie movie)
        {
            GetMovieDTO getMovieDTO = new GetMovieDTO()
            {
                Id = movie.Id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            };

            return getMovieDTO;
        }

        public static GetScreeningDTO ToScreeningDTO(Screening entity)
        {
            GetScreeningDTO GetScreeningDTO = new()
            {
                Id = entity.Id,
                ScreenNumber = entity.ScreenNumber,
                StartsAt = entity.StartsAt,
                UpdatedAt = entity.UpdatedAt,
                CreatedAt = entity.CreatedAt,

            };
            return GetScreeningDTO;

        }
    }
}
