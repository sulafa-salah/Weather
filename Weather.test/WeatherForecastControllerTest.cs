using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.API.Controllers;

namespace Weather.test
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void GetWeatherForecast_ReturnsCorrectNumberOfForecasts()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(loggerMock.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(6, result.Count());
        }
    }
}
