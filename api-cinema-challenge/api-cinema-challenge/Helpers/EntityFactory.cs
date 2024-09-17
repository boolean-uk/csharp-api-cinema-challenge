using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using System.Security.Cryptography.Xml;

namespace api_cinema_challenge.Helpers
{
    public static class Transfer
    {
        public static Customer PostCustomer(PostCustomerDTO DTOobject)
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
        public static GetCustomerDTO GetCustomer(Customer customer)
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
        public static Customer UpdateCustomer(PostCustomerDTO DTOobject)
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
        public static Movie PostMovie(PostMovieDTO DTOobject)
        {
            Movie Movie = new()
            {

                Title = DTOobject.Title,
                Rating = DTOobject.Rating,
                Description = DTOobject.Dectription,
                RuntimeMins = DTOobject.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                
            };
            
            return Movie;
        }

        public static Screening PostScreening(PostScreeningDTO DTOobject)
        {
            Screening screening = new()
            {
                Capacity = DTOobject.capacity,
                ScreenNumber = DTOobject.screenNumber,
                StartsAt = DTOobject.startsAt,
            };
            return screening;
        }
    }
}
