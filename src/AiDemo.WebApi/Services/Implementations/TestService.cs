using AiDemo.WebApi.Services.Interfaces;

namespace AiDemo.WebApi.Services.Implementations;

/// <inheritdoc />
public class TestService : ITestService
{
    /// <inheritdoc />
    public string HelloWorld() => "Hello World";
}
