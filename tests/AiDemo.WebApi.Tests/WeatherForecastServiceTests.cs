using AiDemo.WebApi.Models;
using AiDemo.WebApi.Services.Implementations;
using Xunit;

namespace AiDemo.WebApi.Tests;

public class WeatherForecastServiceTests
{
    private readonly WeatherForecastService _service;

    public WeatherForecastServiceTests()
    {
        _service = new WeatherForecastService();
    }

    [Fact]
    public void GetForecast_ReturnsFiveForecasts()
    {
        var result = _service.GetForecast().ToList();

        Assert.Equal(5, result.Count);
    }

    [Fact]
    public void GetForecast_ReturnsForecastsWithFutureDates()
    {
        var now = DateTime.Now;
        var result = _service.GetForecast().ToList();

        foreach (var forecast in result)
        {
            Assert.True(forecast.Date > now);
        }
    }

    [Fact]
    public void GetForecast_ReturnsForecastsWithValidTemperatureRange()
    {
        var result = _service.GetForecast().ToList();

        foreach (var forecast in result)
        {
            Assert.InRange(forecast.TemperatureC, -20, 55);
        }
    }

    [Fact]
    public void GetForecast_ReturnsForecastsWithNonEmptySummary()
    {
        var result = _service.GetForecast().ToList();

        foreach (var forecast in result)
        {
            Assert.False(string.IsNullOrWhiteSpace(forecast.Summary));
        }
    }

    [Fact]
    public void GetForecast_ReturnsForecastsWithValidSummary()
    {
        var validSummaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var result = _service.GetForecast().ToList();

        foreach (var forecast in result)
        {
            Assert.Contains(forecast.Summary, validSummaries);
        }
    }
}
