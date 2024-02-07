using api_cinema_challenge.Endoints;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Model;
using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace api_cinema_challenge_test
{
    public class CinemaApiTests
    {
        [Fact]
        public async Task TestCreateAndUpdateBooking()
        {
            var mockRepo = new Mock<IBookingRepository>();
            var bookingDto = new BookingDto { Id = 1 , CustomerId = 1 , ScreeningId = 1 , NumberOfSeats = 2 , SeatIds = new List<int> { 1 , 2 } };
            var booking = new Booking { Id = 1 , CustomerId = 1 , ScreeningId = 1 , NumberOfSeats = 2 , Seats = new List<Seat> { new Seat { Id = 1 } , new Seat { Id = 2 } } };
            mockRepo.Setup(repo => repo.CreateBooking(It.IsAny<Booking>())).ReturnsAsync(booking);

            var resultCreate = await BookingEndpoint.CreateBooking(mockRepo.Object , bookingDto);
            var createResult = Assert.IsType<CreatedResult>(resultCreate);
            Assert.Equal($"/bookings/{booking.Id}" , createResult.Location);
            Assert.Equal(booking , createResult.Value);
        }

        [Fact]
        public async Task TestCreateAndUpdateSeat()
        {

            var mockRepo = new Mock<ISeatRepository>();
            var seatDto = new SeatDto { Id = 1 , SeatNumber = 1 , RowNumber = 1 , ScreenId = 1 };
            var seat = new Seat { Id = 1 , SeatNumber = 1 , RowNumber = 1 , ScreenId = 1 };
            mockRepo.Setup(repo => repo.CreateSeat(It.IsAny<Seat>())).ReturnsAsync(seat);
            mockRepo.Setup(repo => repo.UpdateSeat(It.IsAny<int>() , It.IsAny<Seat>())).ReturnsAsync(seat);

            var resultCreate = await SeatEndpoint.CreateSeat(mockRepo.Object , seatDto);
            var resultUpdate = await SeatEndpoint.UpdateSeat(mockRepo.Object , seat.Id , seatDto);

            var createResult = Assert.IsType<CreatedResult>(resultCreate);
            var updateResult = Assert.IsType<OkObjectResult>(resultUpdate);
            Assert.Equal($"/seats/{seat.Id}" , createResult.Location);
            Assert.Equal(seat , createResult.Value);
            Assert.Equal(seat , updateResult.Value);
        }

        [Fact]
        public async Task TestCreateAndUpdateTicket()
        {
            // Arrange
            var mockRepo = new Mock<ITicketRepository>();
            var ticketDto = new TicketDto { Id = 1 , SeatId = 1 , ScreeningId = 1 };
            var ticket = new Ticket { Id = 1 , SeatId = 1 , ScreeningId = 1 };
            mockRepo.Setup(repo => repo.CreateTicket(It.IsAny<Ticket>())).ReturnsAsync(ticket);
            mockRepo.Setup(repo => repo.UpdateTicket(It.IsAny<int>() , It.IsAny<Ticket>())).ReturnsAsync(ticket);

            // Act
            var resultCreate = await TicketEndpoint.CreateTicket(mockRepo.Object , ticketDto);
            var resultUpdate = await TicketEndpoint.UpdateTicket(mockRepo.Object , ticket.Id , ticketDto);

            // Assert
            var createResult = Assert.IsType<CreatedResult>(resultCreate);
            var updateResult = Assert.IsType<OkObjectResult>(resultUpdate);
            Assert.Equal($"/tickets/{ticket.Id}" , createResult.Location);
            Assert.Equal(ticket , createResult.Value);
            Assert.Equal(ticket , updateResult.Value);
        }

        // Movie Tests
        [Fact]
        public async Task TestCreateAndUpdateMovie()
        {

            var mockRepo = new Mock<IMovieRepository>();
            var movieDto = new MovieDto { Id = 1 , Title = "Test Movie" , Rating = "good" , RuntimeMins = 120 };
            var movie = new Movie { Id = 1 , Title = "Test Movie" , Rating = "bad" , RuntimeMins = 120 };
            mockRepo.Setup(repo => repo.CreateMovie(It.IsAny<Movie>())).ReturnsAsync(movie);
            mockRepo.Setup(repo => repo.UpdateMovie(It.IsAny<int>() , It.IsAny<Movie>())).ReturnsAsync(movie);

            var resultCreate = await MovieEndpoint.CreateMovie(mockRepo.Object , movieDto);
            var resultUpdate = await MovieEndpoint.UpdateMovie(mockRepo.Object , movie.Id , movieDto);

            var createResult = Assert.IsType<CreatedResult>(resultCreate);
            var updateResult = Assert.IsType<OkObjectResult>(resultUpdate);
            Assert.Equal($"/movies/{movie.Id}" , createResult.Location);
            Assert.Equal(movie , createResult.Value);
            Assert.Equal(movie , updateResult.Value);
        }

        // Screening Tests
        [Fact]
        public async Task TestCreateAndUpdateScreening()
        {

            var mockRepo = new Mock<IScreeningRepository>();
            var screeningDto = new ScreeningDto { Id = 1 , MovieId = 1 , StartsAt = DateTime.Now };
            var screening = new Screening { Id = 1 , MovieId = 1 , StartsAt = DateTime.Now };
            mockRepo.Setup(repo => repo.CreateScreening(It.IsAny<Screening>())).ReturnsAsync(screening);

            var resultCreate = await ScreeningEndpoint.CreateScreening(mockRepo.Object , screeningDto);

            var createResult = Assert.IsType<CreatedResult>(resultCreate);
            Assert.Equal($"/screenings/{screening.Id}" , createResult.Location);
            Assert.Equal(screening , createResult.Value);
        }
    }
}