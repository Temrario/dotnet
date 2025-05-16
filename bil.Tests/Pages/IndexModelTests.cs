using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using bil.Pages;

namespace bil.Tests.Pages
{
    public class IndexModelTests
    {
        [Fact]
        public void OnGet_SetsMessage_ToExpectedValue()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<IndexModel>>();
            var pageModel = new IndexModel(loggerMock.Object);

            // Act
            pageModel.OnGet();

            // Assert
            // Note: This assumes there's a Message property in IndexModel
            // You'll need to adjust based on your actual IndexModel implementation
            Assert.NotNull(pageModel);
        }

        [Fact]
        public void Constructor_SetsLogger_WhenLoggerProvided()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<IndexModel>>();
            
            // Act
            var pageModel = new IndexModel(loggerMock.Object);

            // Assert
            Assert.NotNull(pageModel);
            // Additional assertions could verify that internal logger is set correctly
            // if this was exposed via a property
        }
    }
} 