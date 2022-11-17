using Northwind.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Northwind.Test.GetWeatherForecast
{
    public class GetTest
    {
        [Fact]
        public void ShouldReturnWeatherForecastIEnumerable()
        {
            Mock<ILogger<WeatherForecastController>> mockILogger = new();
            WeatherForecastController weatherForecastController  
                = new(mockILogger.Object);
            var arrayFromController = weatherForecastController.Get();
            Assert.NotEmpty(arrayFromController);
        }
    }
}