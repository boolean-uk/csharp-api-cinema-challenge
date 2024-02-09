using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models.TransferModels.Movies;
using api_cinema_challenge.Models.TransferModels.Screenings;
using api_cinema_challenge.Models.InputModels.Screening;
using api_cinema_challenge.Models.InputModels.Movie;
using Microsoft.AspNetCore.Http.HttpResults;
using api_cinema_challenge.Models.TransferModels.Payload;
using api_cinema_challenge.Models.JunctionModel;

namespace api_cinema_challenge.Controllers
{
    public static class MoviesEndpoint
    {
        public static void ConfigureMoviesEndpoint(this WebApplication app)
        {
            var moviesGroup = app.MapGroup("movies/");

            moviesGroup.MapGet("/", GetMovies);
            moviesGroup.MapGet("/{id}", GetMovie);
            moviesGroup.MapPost("/", PostMovie);
            moviesGroup.MapPut("/{id}", PutMovie);
            moviesGroup.MapDelete("/{id}", DeleteMovie);

            moviesGroup.MapGet("{id}/screenings", GetScreeningsOfMovie);
            moviesGroup.MapPost("{id}/screenings", PostScreeningOfMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetMovies(IRepository<Movie> repo)
        {
            IEnumerable<Movie> movies = await repo.GetAllIncluding();

            IEnumerable<MovieDTO> moviesOut = movies.OrderBy(m => m.MovieId).Select(m => new MovieDTO(m.MovieId, m.Title, m.Rating, m.Description, m.RuntimeMinutes, m.CreatedAt, m.UpdatedAt));
            Payload<IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>(moviesOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetMovie(IRepository<Movie> repo, int id)
        {
            Movie? movie = await repo.Get(id);

            if (movie == null)
            {
                return TypedResults.NotFound($"No movie with ID {id} found.");
            }

            MovieDTO movieOut = new MovieDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt);
            Payload<MovieDTO> payload = new Payload<MovieDTO>(movieOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostMovie(
            IRepository<Movie> repo, 
            IRepository<Screening> screeningRepo, 
            IRepository<Display> displayRepo, 
            IRepository<Seat> seatRepo,
            TicketSeatRepository tsRepo,
            MovieInputPostDTO moviePost)
        {


            Movie inputMovie = new Movie()
            {
                Title = moviePost.Title,
                Rating = moviePost.Rating,
                Description = moviePost.Description,
                RuntimeMinutes = moviePost.RuntimeMins,
                CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)
            };
            Movie movie = await repo.Insert(inputMovie);

            if (moviePost.Screenings.Count > 0)
            {
                ICollection<Screening> createdScreenings = new List<Screening>();

                foreach (ScreeningInputAsMovieDTO screening in moviePost.Screenings)
                {
                    Screening screeningGenerated = new Screening();

                    IEnumerable<Display> screeningRooms = await displayRepo.GetAll();
                    Display? screeningRoom = screeningRooms.Where(sr => sr.ScreenNumber == screening.ScreenNumber).FirstOrDefault();
                    if (screeningRoom == null) 
                    {
                        screeningRoom = new Display()
                        {
                            ScreenNumber = screening.ScreenNumber,
                            Capacity = screening.Capacity,
                            CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                            UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                        };
                        screeningRoom.Screenings.Add(screeningGenerated);
                    }


                    screeningGenerated.DisplayId = screeningGenerated.DisplayId;
                    screeningGenerated.Display = screeningRoom;
                    screeningGenerated.Starts = DateTime.SpecifyKind(DateTime.Parse(screening.StartsAt), DateTimeKind.Utc);
                    screeningGenerated.CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
                    screeningGenerated.UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
                    screeningGenerated.MovieId = movie.MovieId;

                    createdScreenings.Add(screeningGenerated);
                }

                foreach (Screening screening in createdScreenings)
                {
                    Screening newScreening = await screeningRepo.Insert(screening);
                    Random rng = new Random();
                    int seats = screening.Display.Capacity;
                    int rows = rng.Next(3, Math.Max(6, seats / 6));
                    int seatPerRow = seats / rows;

                    for (int j = 1; j <= seats; j++)
                    {
                        int RowNumber = j - 1 / seatPerRow + 1;
                        int seatNumber = (j - 1) % seatPerRow + 1;

                        Seat seat = new Seat();
                        seat.SeatId = j;
                        seat.RowNumber = RowNumber;
                        seat.SeatNumber = seatNumber;
                        seat.DisplayId = newScreening.DisplayId;
                        await seatRepo.Insert(seat);

                        TicketSeat ts = new TicketSeat() { SeatId = seat.SeatId, DisplayId = newScreening.DisplayId, ScreeningId = newScreening.ScreeningId};
                        await tsRepo.Insert(ts);
                    }
                }

            }

            MovieWithScreeningDTO movieOut = new MovieWithScreeningDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt, movie.Screenings);
            Payload<MovieWithScreeningDTO> payload = new Payload<MovieWithScreeningDTO>(movieOut);
            return TypedResults.Created($"/{movieOut.MovieId}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PutMovie(IRepository<Movie> repo, int id, MoveInputDTO moviePut)
        {
            Movie? movie = await repo.Get(id);

            if (movie == null)
            {
                return TypedResults.NotFound($"No movie with ID {id} found.");
            }

            Movie inputMovie = new Movie()
            {
                MovieId = movie.MovieId,
                Title = moviePut.Title ?? movie.Title,
                Rating = moviePut.Rating ?? movie.Rating,
                Description = moviePut.Description ?? movie.Description,
                RuntimeMinutes = moviePut.RuntimeMins,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
            };

            movie = await repo.Update(id, inputMovie);

            MovieDTO movieOut = new MovieDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt);
            Payload<MovieDTO> payload = new Payload<MovieDTO>(movieOut);
            return TypedResults.Created($"/{movieOut.Id}", payload);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(IRepository<Movie> repo, int id)
        {
            Movie? movie = await repo.Get(id);

            if (movie == null)
            {
                return TypedResults.NotFound($"No movie with ID {id} found.");
            }

            movie = await repo.Delete(id);

            MovieDTO movieOut = new MovieDTO(movie.MovieId, movie.Title, movie.Rating, movie.Description, movie.RuntimeMinutes, movie.CreatedAt, movie.UpdatedAt);
            Payload<MovieDTO> payload = new Payload<MovieDTO>(movieOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetScreeningsOfMovie(IRepository<Movie> repo, int id)
        {
            Movie? movieWithScreenings = await repo.GetIncluding(id, "MovieId", (m => m.Screenings));
            if (movieWithScreenings == null) 
            {
                return TypedResults.NotFound($"Could not find any movie with the ID {id}.");
            }

            IEnumerable<ScreeningDTO> screeningsOut = movieWithScreenings.Screenings.Select(s => new ScreeningDTO(s.ScreeningId, s.Display.ScreenNumber, s.Display.Capacity, s.Starts, s.CreatedAt, s.UpdatedAt));
            Payload<IEnumerable<ScreeningDTO>> payload = new Payload<IEnumerable<ScreeningDTO>>(screeningsOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostScreeningOfMovie(
            IRepository<Screening> repo, 
            IRepository<Display> displayRepo,
            IRepository<Seat> seatRepo,
            TicketSeatRepository tsRepo,
            int id, 
            ScreeningInputAsMovieDTO screeningPost)
        {

            IEnumerable<Display> screeningRooms = await displayRepo.GetAll();
            Display? screeningRoom = screeningRooms
                .Where(sr => sr.ScreenNumber == screeningPost.ScreenNumber && sr.Capacity == screeningPost.Capacity)
                .FirstOrDefault();
            if (screeningRoom == null)
            {
                screeningRoom = new Display()
                {
                    ScreenNumber = screeningPost.ScreenNumber,
                    Capacity = screeningPost.Capacity,
                    CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                    UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),

                };
                screeningRoom = await displayRepo.Insert(screeningRoom);
            }

            Screening inputScreening = new Screening()
            {
                DisplayId = screeningRoom.DisplayId,
                Display = screeningRoom,
                Starts = DateTime.SpecifyKind(DateTime.Parse(screeningPost.StartsAt), DateTimeKind.Utc),
                MovieId = id,
                CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)
            };

            screeningRoom.Screenings.Add(inputScreening);
            Screening screening = await repo.Insert(inputScreening);

            Random rng = new Random();
            int seats = screening.Display.Capacity;
            int rows = rng.Next(3, Math.Max(6, seats / 6));
            int seatPerRow = seats / rows;

            for (int j = 1; j <= seats; j++)
            {
                int RowNumber = j - 1 / seatPerRow + 1;
                int seatNumber = (j - 1) % seatPerRow + 1;

                Seat seat = new Seat();
                seat.SeatId = j;
                seat.RowNumber = RowNumber;
                seat.SeatNumber = seatNumber;
                seat.DisplayId = screening.DisplayId;
                await seatRepo.Insert(seat);

                TicketSeat ts = new TicketSeat() { SeatId = seat.SeatId, DisplayId = screening.DisplayId, ScreeningId = screening.ScreeningId };
                await tsRepo.Insert(ts);
            }

            ScreeningDTO screeningOut = new ScreeningDTO(screening.ScreeningId, screening.DisplayId, screening.Display.Capacity, screening.Starts, screening.CreatedAt, screening.UpdatedAt);
            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>(screeningOut);
            return TypedResults.Created($"/{screeningOut.Id}", payload);
        }
    }
}
