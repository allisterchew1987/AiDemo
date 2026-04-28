using AiDemo.WebApi.Services.Interfaces;

namespace AiDemo.WebApi.Services.Implementations;

/// <inheritdoc />
public class HelloService : IHelloService
{
    /// <inheritdoc />
    public string GetHelloWorld() => "Hello World";
}
