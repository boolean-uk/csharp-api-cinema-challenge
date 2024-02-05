using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net.Http.Json;
using api_cinema_challenge;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Numerics;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;


namespace unittests
{
    public class CustomerTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public async Task CustomerEndpointStatus()
        {
            // Arrange
            var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
            var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync("/cinema/customers");

            // Assert
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }




        [Test]
        public async Task CreateCustomer()
        {

            var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
            var client = factory.CreateClient();

            var res = await client.GetAsync("/cinema/customers");


            var expectedPayload = new List<Customer>()
            {
                new Customer {  Name = "Gary Way", Email = "gary@gmail.com", Phone = "+12345678" }
            };

            var obj = new
            {
                name = "Gary Way",
                email = "gary@gmail.com",
                phone = "+12345678"
            };

            JsonContent content = JsonContent.Create(obj);

            var response = await client.PostAsync("/cinema/customers", content);

            var responsePayload = response.Content.ReadFromJsonAsync<Object>();

            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.Created));

        }
    }
}