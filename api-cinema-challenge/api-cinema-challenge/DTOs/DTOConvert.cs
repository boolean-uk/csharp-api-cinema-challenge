
using api_cinema_challenge.Models;
using System.Net.Sockets;

namespace api_cinema_challenge.DTOs
{
    public static class DTOConvert
    {
        internal static DTOCustomerObject DTOConvertObject(Customer customer)
        {
            return new DTOCustomerObject(customer.Id,customer.Name, customer.Email,customer.Phone,customer.Created,customer.Updated);
        }

        internal static DTOMovieObject DTOConvertObject(Movie movie)
        {
            return new DTOMovieObject(movie.Id,movie.Title, movie.Description, movie.Rating, movie.RuntimeMins, movie.Screenings, movie.Created, movie.Updated);
        }

        internal static DTOScreeningObject DTOConvertObject(Screening screening)
        {
            return new DTOScreeningObject(screening.Id, screening.ScreenNumber,screening.Capacity, screening.StartsAt, screening.Created, screening.Updated);
        }

        internal static DTOTicketObject DTOConvertObject(Ticket ticket)
        {
            return new DTOTicketObject(ticket.Id, ticket.ScreeningId, ticket.Created);
        }

        internal static IEnumerable<DTOCustomerObject> DTOConvertList(IEnumerable<Customer> customers)
        {
            return customers.Select(customer => new DTOCustomerObject(customer.Id, customer.Name, customer.Email, customer.Phone, customer.Created, customer.Updated));
        }
        internal static IEnumerable<DTOMovieObject> DTOConvertList(IEnumerable<Movie> movies)
        {
            return movies.Select(movie => new DTOMovieObject(movie.Id, movie.Title, movie.Description, movie.Rating, movie.RuntimeMins, movie.Screenings, movie.Created, movie.Updated));
        }

        internal static IEnumerable<DTOScreeningObject> DTOConvertList(IEnumerable<Screening> screenings)
        {
            return screenings.Select(screening => new DTOScreeningObject(screening.Id, screening.ScreenNumber, screening.Capacity, screening.StartsAt, screening.Created, screening.Updated));
        }
        internal static IEnumerable<DTOTicketObject> DTOConvertList(IEnumerable<Ticket> tickets)
        {
            return tickets.Select(ticket => new DTOTicketObject(ticket.Id, ticket.ScreeningId, ticket.Created));
        }
    }
}
