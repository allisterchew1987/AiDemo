namespace AiDemo.WebApi.Services.Interfaces;

public interface IGreetingService
{
    Task<string> GetGreetingAsync();
}
