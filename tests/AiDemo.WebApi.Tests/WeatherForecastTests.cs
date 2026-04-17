using AiDemo.WebApi.Models;
using Xunit;

namespace AiDemo.WebApi.Tests;

public class WeatherForecastTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 211)]
    [InlineData(-40, -39)]
    [InlineData(37, 98)]
    public void TemperatureF_CalculatesCorrectly(int temperatureC, int expectedTemperatureF)
    {
        var forecast = new WeatherForecast(DateTime.Now, temperatureC, "Test");

        Assert.Equal(expectedTemperatureF, forecast.TemperatureF);
    }

    [Fact]
    public void WeatherForecast_StoresPropertiesCorrectly()
    {
        var date = new DateTime(2024, 1, 1);
        const int temperatureC = 25;
        const string summary = "Warm";

        var forecast = new WeatherForecast(date, temperatureC, summary);

        Assert.Equal(date, forecast.Date);
        Assert.Equal(temperatureC, forecast.TemperatureC);
        Assert.Equal(summary, forecast.Summary);
    }
}
