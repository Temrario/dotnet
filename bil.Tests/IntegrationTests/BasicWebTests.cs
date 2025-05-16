using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using bil.Tests.TestHelpers;

namespace bil.Tests.IntegrationTests
{
    public class BasicWebTests : IClassFixture<WebApplicationFactory<ProgramWrapper>>
    {
        private readonly WebApplicationFactory<ProgramWrapper> _factory;

        public BasicWebTests(WebApplicationFactory<ProgramWrapper> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Index")]
        [InlineData("/Privacy")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status code 200-299
            Assert.Equal("text/html; charset=utf-8", 
                response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task Get_ErrorPage_ReturnsNotFoundForInvalidPage()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/InvalidPage");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
} 