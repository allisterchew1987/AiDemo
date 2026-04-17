using AiDemo.WebApi.Services.Interfaces;

namespace AiDemo.WebApi.Services.Implementations;

public class GreetingService : IGreetingService
{
    public async Task<string> GetGreetingAsync()
    {
        return await Task.FromResult("Hello from AiDemo Greeting Service!");
    }
}
