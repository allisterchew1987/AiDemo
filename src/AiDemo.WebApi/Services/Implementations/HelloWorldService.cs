using AiDemo.WebApi.Services.Interfaces;

namespace AiDemo.WebApi.Services.Implementations;

/// <inheritdoc />
public class HelloWorldService : IHelloWorldService
{
    /// <inheritdoc />
    public string GetHelloWorld() => "Hello World";
}
