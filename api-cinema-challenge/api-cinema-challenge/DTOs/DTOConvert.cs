
using api_cinema_challenge.Models;
using System.Net.Sockets;

namespace api_cinema_challenge.DTOs
{
    public static class DTOConvert
    {
        internal static DTOCustomerObject DTOConvertObject(Customer customer)
        {
            return new DTOCustomerObject() { Id = customer.Id, Name = customer.Name, Email = customer.Email, Phone = customer.Phone, Created = customer.CreatedAt, Updated = customer.UpdatedAt };
        }

        internal static DTOMovieObject DTOConvertObject(Movie movie)
        {
            return new DTOMovieObject() { Id =movie.Id, Title = movie.Title, Description = movie.Description, Rating = movie.Rating, RuntimeMins = movie.RuntimeMins, Screenings = movie.Screenings, Created= movie.CreatedAt, Updated = movie.UpdatedAt };
        }

        internal static DTOScreeningObject DTOConvertObject(Screening screening)
        {
            return new DTOScreeningObject(screening.Id, screening.ScreenNumber,screening.Capacity, screening.StartsAt, screening.CreatedAt, screening.UpdatedAt);
        }

        internal static DTOTicketObject DTOConvertObject(Ticket ticket)
        {
            return new DTOTicketObject(ticket.Id, ticket.NumSeats, ticket.CreatedAt);
        }

        internal static IEnumerable<DTOCustomerObject> DTOConvertList(IEnumerable<Customer> customers)
        {
            return customers.Select(customer => new DTOCustomerObject() { Id = customer.Id, Name= customer.Name, Email = customer.Email, Phone = customer.Phone, Created = customer.CreatedAt, Updated = customer.UpdatedAt });
        }
        internal static IEnumerable<DTOMovieObject> DTOConvertList(IEnumerable<Movie> movies)
        {
            return movies.Select(movie => new DTOMovieObject() { Id = movie.Id, Title = movie.Title, Description = movie.Description, Rating = movie.Rating, RuntimeMins = movie.RuntimeMins, Screenings = movie.Screenings, Created = movie.CreatedAt, Updated = movie.UpdatedAt });
        }

        internal static IEnumerable<DTOScreeningObject> DTOConvertList(IEnumerable<Screening> screenings)
        {
            return screenings.Select(screening => new DTOScreeningObject(screening.Id, screening.ScreenNumber, screening.Capacity, screening.StartsAt, screening.CreatedAt, screening.UpdatedAt));
        }
        internal static IEnumerable<DTOTicketObject> DTOConvertList(IEnumerable<Ticket> tickets)
        {
            return tickets.Select(ticket => new DTOTicketObject(ticket.Id, ticket.NumSeats, ticket.CreatedAt));
        }
    }
}
