using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text;
using api_cinema_challenge.Models;

namespace CinemaTests
{
    [TestFixture]
    public class CinemaEndpointTests
    {
        private WebApplicationFactory<Program> factory;

        [OneTimeSetUp]
        public void Setup()
        {
            factory = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder => { });
        }

        [Test]
        public async Task CreateUserEndpointStatusTest()
        {
            // Arrange
            var client = factory.CreateClient();
            
            var userPayload = "{ \"name\": \"Anders Andersson\", \"email\": \"anders@email.com\", \"phoneNumber\": \"0753344556\" }";
            var content = new StringContent(userPayload, Encoding.UTF8, "application/json");

            // Act
            var response = await client.PostAsync($"/users/users/?name=Anders%20Andersson&email=anders@email.com&phoneNumber=0753344556", content);

            // Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        [Test]
        public async Task UpdateUserEndpointStatusTest()
        {
            // Arrange
            var client = factory.CreateClient();
            var Id = 5;
            var userPayload = "{ \"name\": \"Updated Name\", \"email\": \"updated@email.com\", \"phoneNumber\": \"0777766554\" }";
            var content = new StringContent(userPayload, Encoding.UTF8, "application/json");

            // Act
            var response = await client.PutAsync($"/users/users/{Id}?name=Updated%20Name&email=updated@email.com&phoneNumber=0777766554", content);

            // Assert
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        [Test]
        public async Task GetMoviesEndpointStatusTest()
        {
            // Arrange
            var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync("/movies/movies/");

            // Assert
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }
    }
}