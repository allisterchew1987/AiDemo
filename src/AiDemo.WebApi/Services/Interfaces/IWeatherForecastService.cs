using AiDemo.WebApi.Models;

namespace AiDemo.WebApi.Services.Interfaces;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetForecast();
}
