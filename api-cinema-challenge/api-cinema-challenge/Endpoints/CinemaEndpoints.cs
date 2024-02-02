using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using api_cinema_challenge.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO.Pipes;
using System.Globalization;
using System.Net.Sockets;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {

        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapGet("/customers", GetCustomers);
            // cinemaGroup.MapGet("/customers/{id}", GetCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/customers/{id}", DeleteCustomer);

            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapGet("/movies", GetMovies);
            // cinemaGroup.MapGet("/movies/{id}", GetMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies/{id}", DeleteMovie);

            cinemaGroup.MapPost("/movies/{id}/screenings", CreateScreening);
            cinemaGroup.MapGet("/movies/{id}/screenings", GetScreenings);


            // http://localhost:4000/customers/{customerId}/screenings/{screeningId}
            cinemaGroup.MapPost("/customers/{customerId}/screenings/{screeningId}", CreateTicket);
            cinemaGroup.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTickets);

        }

        /// AID FUNCTIONS
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public static bool correctDateTimeFormat(string inputString)
        {
           
            return DateTime.TryParseExact(inputString, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);
   
        }

        /// CUSTOMERS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        { 

            var customers = await repository.GetCustomers();

            List<Object> custDTO = new List<Object>();

            foreach (Customer customer in customers)
            {
                var cust = new CustomerDTO(customer);
                custDTO.Add(cust);
            }

            StatusListDto sto = new StatusListDto(custDTO);

            return TypedResults.Ok(sto);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(CreateCustomerPayload payload, IRepository repository)
        {

            if (payload.Name == "" || payload.Phone == "" || payload.Email == "")
            {
                return Results.BadRequest("Non-empty fields are required.");
            }

            if (payload.Name == null || payload.Phone == null || payload.Email == null)
            {
                return Results.BadRequest("Non-null fields are required.");
            }

            if (IsValidEmail(payload.Email) == false)
            {
                return Results.BadRequest("Email needs to be in correct format.");
            }

            Customer? customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            CustomerDTO cust = new CustomerDTO(customer);

            return TypedResults.Created($"/customers{customer.Id}", new StatusSingleDto( cust ));
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteCustomer(int id, IRepository repository)
        {

            Customer? customer = await repository.DeleteCustomer(id, PreloadPolicy.PreloadRelations);

            if (customer == null)
            {
                return Results.NotFound("customer not found");
            }

            CustomerDTO customerDTO = new CustomerDTO(customer);
            StatusSingleDto sto = new StatusSingleDto( customerDTO );

            repository.SaveChanges();

            return TypedResults.Ok(sto);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(int id, UpdateCustomerPayload payload, IRepository repository)
        {

            var ogcust = repository.GetCustomers().Result.FirstOrDefault(x => x.Id == id);

            if (ogcust == null)
            {
                return Results.BadRequest("The customer does not exist.");
            }

            string newName = ogcust.Name;
            string newEmail = ogcust.Email;
            string newPhone = ogcust.Phone;

            bool emailFlag = false;

            if (payload.name == "" && payload.phone == "" && payload.email == "")
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (payload.name != null && payload.name.Length > 0)
            {
                newName = payload.name;
            }

            if (payload.phone != null && payload.phone.Length > 0)
            {
                newPhone = payload.phone;
            }

            if (payload.email != null && payload.email.Length > 0)
            {
                emailFlag = true;
            }

            if (emailFlag && IsValidEmail(payload.email) == false)
            {
                return Results.BadRequest("Email format was incorrect!");
            }

            else if (emailFlag && IsValidEmail(payload.email) == true)
            {
                newEmail = payload.email;
            }



            Customer? customer = await repository.UpdateCustomer(id, newName, newEmail, newPhone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            CustomerDTO cdto = new CustomerDTO(customer);
            StatusSingleDto sto = new StatusSingleDto( cdto );

            return TypedResults.Created($"/customers{customer.Id}", sto);
        }




        /// MOVIES
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        { 

            var movies = await repository.GetMovies();

            List<Object> fstatus = new List<object>();


            foreach (Movie movie in movies)
            {
                MovieDTO dt = new MovieDTO(movie);

                fstatus.Add(dt);
            }

            var statusDTO = new StatusListDto(fstatus);

            return TypedResults.Ok(statusDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(CreateMoviePayload payload, IRepository repository)
        {

            List<Screening> scrs = new List<Screening>();
         
            if (payload.title == "" || payload.rating == "" || payload.description == "" || payload.runtimeMins < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (payload.title == null || payload.rating == null || payload.description == null )
            {
                return Results.BadRequest("Non-null fields are required");
            }
        
            Movie? movie = await repository.CreateMovie(payload.title, payload.rating, payload.description, payload.runtimeMins);

            if (movie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }

            repository.SaveChanges(); // !!!

            if (payload.Screenings != null && payload.Screenings.Count() > 0)
            {
                foreach(CreateScreeningPayload sc in payload.Screenings)
                {

                    if (correctDateTimeFormat(sc.startsAt) == false) 
                    {
                        return Results.BadRequest("Give datetime in the correct format: YYYY-MM-DD HH:MM:SS");
                    }

                    Screening? screening = await repository
                        .CreateScreening(
                        sc.screenNumber, 
                        sc.capacity, 
                        DateTime.Parse(sc.startsAt).ToUniversalTime(), 
                        movie.Id);

                    if (screening == null)
                    {
                        return Results.BadRequest("Screening could not be created!");
                    }
                }
                
            }

            repository.SaveChanges();

            MovieDTO mdto = new MovieDTO(movie);

            return TypedResults.Created($"/movies{movie.Id}", new StatusSingleDto( mdto ));
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteMovie(int id, IRepository repository)
        {

            Movie? movie = await repository.DeleteMovie(id, PreloadPolicy.PreloadRelations);

            if (movie == null)
            {
                return Results.NotFound("Movie not found");
            }

            var MovieDTO = new MovieDTO(movie);
            var StatusDTO = new StatusSingleDto( MovieDTO );

            repository.SaveChanges();

            return TypedResults.Ok(StatusDTO);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateMovie(int id, UpdateMoviePayload payload, IRepository repository)
        {


            // nothing to update
            if (payload.title == "" && payload.rating == "" && payload.description == "" && payload.runtimeMins < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (payload.title == null || payload.rating == null || payload.description == null || payload.runtimeMins == null)
            {
                return Results.BadRequest("Non-null fields are required");
            }

            Movie ogMovie = repository.GetMovies().Result.FirstOrDefault(x => x.Id == id);

            if (ogMovie == null)
            {
                return Results.BadRequest("Movie not found");
            }

            string newTitle = (payload.title.Length > 0) ? payload.title : ogMovie.Title;
            string newRating = (payload.rating.Length > 0) ? payload.rating : ogMovie.Rating;
            string newDescription = (payload.description.Length > 0) ? payload.description : ogMovie.Description;
            int newRuntimeMins = (payload.runtimeMins != ogMovie.RuntimeMins && payload.runtimeMins != 0) ? payload.runtimeMins : ogMovie.RuntimeMins;
        
            Movie? movie = await repository.UpdateMovie(id, newTitle, newRating, newDescription, newRuntimeMins);

            if (movie == null)
            {
                return Results.BadRequest("Failed to create movie.");
            }


            MovieDTO mv = new MovieDTO(movie);
            StatusSingleDto sto = new StatusSingleDto( mv );

            repository.SaveChanges();

            return TypedResults.Created($"/movies{movie.Id}", sto);
        }






        /// SCREENINGS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(int id, IRepository repository)
        { 

            var screenings = await repository.GetScreenings(id);

            List<Object> fstatus = new List<Object>();

            foreach (Screening screening in screenings)
            {
                var scr = new ScreeningDTO(screening);
                fstatus.Add(scr);
            }

            var statusDTO = new StatusListDto(fstatus);

            return TypedResults.Ok(statusDTO);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  // [AsParameters]
        public static async Task<IResult> CreateScreening(int id, CreateScreeningPayload payload, IRepository repository)
        {

            if (payload.screenNumber <= 0 || payload.capacity <= 0 || id < 0)
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            if (correctDateTimeFormat(payload.startsAt) == false) 
            {
                return Results.BadRequest("Give datetime in the correct format: YYYY-MM-DD HH:MM:SS");
            }
        
            Screening? screening = await repository.CreateScreening(
                payload.screenNumber,
                payload.capacity,
                DateTime.Parse(payload.startsAt).ToUniversalTime(),
            id);


            if (screening == null)
            {
                return Results.BadRequest("Screening could not be created!");
            }

            repository.SaveChanges();

            ScreeningDTO screeningDTO = new ScreeningDTO(screening);
            StatusSingleDto sto = new StatusSingleDto( screeningDTO );

            return TypedResults.Created($"/screenings{screening.Id}", sto);
        }




        //{customerId}/screenings/{screeningId}
        /// TICKETS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(int customerId, int screeningId, IRepository repository)
        {

            var tickets = await repository.GetTickets(customerId, screeningId);

            List<Object> fstatus = new List<Object>();

            foreach (Ticket t in tickets)
            {
                var tic = new TicketDTO(t);
                fstatus.Add(tic);
               
            }

            var statusDTO = new StatusListDto(fstatus);

            return TypedResults.Ok(statusDTO);
        }


        // {customerId}/screenings/{screeningId}
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]  // [AsParameters]
        public static async Task<IResult> CreateTicket(int customerId, int screeningId, CreateTicketPayload payload, IRepository repository)
        {

            if (payload.numSeats <= 0)
            {
                return Results.BadRequest("Non-zero positive seat amount is required");
            }


            Ticket? ticket = await repository.CreateTicket(customerId, screeningId, payload.numSeats);

            if (ticket == null)
            {
                return Results.BadRequest("Customer or screening does not exist!");
            }

            repository.SaveChanges();

            TicketDTO tdo = new TicketDTO(ticket);

            return TypedResults.Created($"/{customerId}/screenings/{screeningId}", new StatusSingleDto( tdo ));
        }
    }
}
